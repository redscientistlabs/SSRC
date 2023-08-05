using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SSRC
{
    public class WizardOrchestrator
    {
        //Session Singleton
        public static WizardOrchestrator Session = null;

        //References for UI
        Panel anchorPanel;
        WizardHeader headerForm;

        //Workflow Variables
        public WizardStep step = WizardStep.UNINITIALIZED;

        public string RomPath = null;
        public byte[] RomData = null;

        public bool UseCustomValueRange = false;
        public CustomRange CustomValueRange = null;

        public bool UseCustomTargetRange = false;
        public CustomRange CustomTargetRange = null;

        public int Intensity = 69;
        public int AmountCorruptedFiles = 420;
        public bool ExecEmu = true;
        public bool MultipleCorrupt = false;
        public bool UseGuidFilenames = false;
        public bool AutoKillEmu = true;
        public string EmuPath = "";
        public string CorruptedFolder = "";

        //Step Forms
        WizardStepStart StepStart = null;
        WizardStepSelectRom StepSelectRom = null;
        WizardStepEngineConfig StepEngineConfig = null;
        WizardStepTargetSetup StepTargetSetup = null;
        WizardStepRunCorrupt StepRunCorrupt = null;

        //Delegate stuff
        public delegate void ShowCorrupt();
        public ShowCorrupt myDelegate;


        public WizardOrchestrator(Panel _anchorPanel, WizardHeader _headerForm)
        {
            anchorPanel = _anchorPanel;
            headerForm = _headerForm;

            Session = this;

            myDelegate = new ShowCorrupt(ShowCorruptButton);
        }


        public void InitializeWorkflow()
        {
            //Send workflow to Start
            step = WizardStep.UNINITIALIZED;

            NextStep();
        }

        public void ShowCorruptButton()
        {
            StepRunCorrupt.btnCorrupt.Visible = true;
        }

        internal void GoToStep(string stepName)
        {
            //validate first and prevent to move if invalid
            var currentForm = anchorPanel.Controls[0];
            if(currentForm is IValidatable iv)
            {
                if (!iv.Validate())
                    return;
            }


            //Find step by name and set as current step
            WizardStep gotoStep = (WizardStep)Enum.Parse(typeof(WizardStep), stepName);
            step = gotoStep;

            //Refresh the interface with the current step
            ProcessStep();
        }

        public void NextStep()
        {
            //Move to next step in workflow
            int nextStep = (int)step + 1;
            step = (WizardStep)nextStep;

            //Refresh the interface with the current step
            ProcessStep();
        }

        public void ProcessStep()
        {
            //unselect all active buttons (visually)
            foreach (Control c in headerForm.Controls)
                if (c is Button && ((Button)c).ForeColor != Color.Gray)
                    ((Button)c).BackColor = Color.FromArgb(64, 64, 64);

            //Find the button for the current step and activate it
            Button btnStep = FindButtonStep();
            headerForm.lbCurrentStep.Text = $"Current step: {btnStep.Text}";
            ActivateButtonStep(btnStep);

            //Change the view for the current step
            AnchorStep();
        }

        internal void InvalidatePostSelectRomSteps()
        {
            //this is used to revert back the workflow after a rom has been changed.

            //dont waste precious cycles if we never went further
            if (headerForm.btnEngineConfig.ForeColor != Color.Gray)
            {
                //deactivate post rom buttons
                headerForm.btnEngineConfig.ForeColor = Color.Gray;
                headerForm.btnTargetSetup.ForeColor = Color.Gray;
                headerForm.btnRunCorrupt.ForeColor = Color.Gray;

                headerForm.btnEngineConfig.BackColor = Color.FromArgb(40, 40, 40);
                headerForm.btnTargetSetup.BackColor = Color.FromArgb(40, 40, 40);
                headerForm.btnRunCorrupt.BackColor = Color.FromArgb(40, 40, 40);

                //delete references to post select-rom forms
                StepEngineConfig = null;
                StepTargetSetup = null;
                StepRunCorrupt = null;

                //reset session vars
                RomData = null;

                UseCustomValueRange = false;
                CustomValueRange = null;

                UseCustomTargetRange = false;
                CustomTargetRange = null;

                Intensity = 69;
                AmountCorruptedFiles = 420;
                ExecEmu = true;
                MultipleCorrupt = false;
                UseGuidFilenames = false;
                AutoKillEmu = true;
                EmuPath = "";
                CorruptedFolder = "";

            }
        }

        public void ActivateButtonStep(Button btnStep)
        {
            btnStep.BackColor = Color.FromArgb(96, 96, 96); //Selected BackColor
            btnStep.ForeColor = Color.FromArgb(240, 240, 240); //Activated ForeColor
        }
        public Button FindButtonStep()
        {
            string tagSearch = step.ToString().ToUpper();

            //Button tags in the header match enum names

            foreach (Control c in headerForm.Controls)
                if (c is Button && ((Button)c).Tag?.ToString() == tagSearch)
                    return (Button)c;

            return null;
        }
        public void AnchorStep()
        {
            Form stepForm = null;

            switch (step)
            {
                case WizardStep.START:
                    if (StepStart == null)
                        StepStart = new WizardStepStart();
                    stepForm = StepStart;
                    break;

                case WizardStep.SELECTROM:
                    if (StepSelectRom == null)
                        StepSelectRom = new WizardStepSelectRom();
                    stepForm = StepSelectRom;
                    break;

                case WizardStep.ENGINECONFIG:
                    if (StepEngineConfig == null)
                        StepEngineConfig = new WizardStepEngineConfig();
                    stepForm = StepEngineConfig;
                    break;

                case WizardStep.TARGETSETUP:
                    if (StepTargetSetup == null)
                        StepTargetSetup = new WizardStepTargetSetup();
                    stepForm = StepTargetSetup;
                    break;

                case WizardStep.RUNCORRUPT:
                    if (StepRunCorrupt == null)
                        StepRunCorrupt = new WizardStepRunCorrupt();
                    stepForm = StepRunCorrupt;
                    break;

                default:
                    return;

            }

            if (stepForm != null)
            {
                HelperMethods.AnchorForm(anchorPanel, stepForm);
            }
        }

        public void RunCorrupt()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            var fi = new FileInfo(RomPath);

            //Pre-execution checks
            if (ExecEmu && !File.Exists(EmuPath)) //making sure the emulator exists
            {
                MessageBox.Show("Could not find emulator file. Aborting Corruption");
                return;
            }

            if(MultipleCorrupt && !Directory.Exists(CorruptedFolder)) //making sure the corrupted folder exists
            {
                MessageBox.Show("Could not find target folder for generating Multiple files. Aborting Corruption");
                return;
            }


            StepRunCorrupt.btnCorrupt.Visible = false;

            var pts = new System.Threading.ParameterizedThreadStart((o) =>
            {
                try
                {
                    string CorruptedFilename = null;
                    if (!MultipleCorrupt)
                    {
                        //only one corruption

                        CorruptedFilename = Path.Combine(fi.Directory.FullName, $"{fi.Name.Replace("." + fi.Extension, "")}_corrupted{fi.Extension}");
                        var corruptedData = GenerateCorruption(rnd);

                        while (true)
                        {
                            try
                            {
                                File.WriteAllBytes(CorruptedFilename, corruptedData);
                                break;
                            }
                            catch
                            {
                                var result = MessageBox.Show("Could not write corrupted file, it might be still in use. Try again?", "Error writing file", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                if (result == DialogResult.No)
                                    return;
                            }
                        }

                        if (ExecEmu) //run in emulator if requested
                        {

                            if (AutoKillEmu)
                            {
                                ProcessStartInfo psiKill = new ProcessStartInfo();
                                psiKill.FileName = "taskkill";
                                psiKill.Arguments = $"/F /IM \"{Path.GetFileName(EmuPath)}\"";
                                psiKill.CreateNoWindow = true;
                                psiKill.UseShellExecute = false;
                                var p = Process.Start(psiKill);
                                p.WaitForExit();
                            }


                            ProcessStartInfo psi = new ProcessStartInfo();
                            psi.FileName = EmuPath;
                            psi.Arguments = $"\"{CorruptedFilename}\"";
                            psi.WorkingDirectory = Path.GetDirectoryName(EmuPath);

                            Process.Start(psi);
                        }
                    }
                    else
                    {
                        //cleaning up destination folder
                        if (!WizardOrchestrator.Session.UseGuidFilenames) //for named corruptions 1,2,3,4 etc
                        {
                            var destFiles = Directory.GetFiles(CorruptedFolder);
                            foreach (var file in destFiles)
                            {
                                if (file.Contains(Path.GetFileNameWithoutExtension(RomPath)))
                                {
                                    File.Delete(file);
                                }
                            }
                        }

                        //executing for multiple files
                        for (int i = 0; i < AmountCorruptedFiles; i++)
                        {
                            var corruptedData = GenerateCorruption(rnd);

                            if (WizardOrchestrator.Session.UseGuidFilenames)
                            {
                                var guid = Guid.NewGuid().ToString("N").ToString().ToUpper();
                                CorruptedFilename = Path.Combine(CorruptedFolder, $"{guid}{fi.Extension}");
                            }
                            else
                                CorruptedFilename = Path.Combine(CorruptedFolder, $"{fi.Name.Replace("." + fi.Extension, "")}_corrupted_{i}_{fi.Extension}");

                            File.WriteAllBytes(CorruptedFilename, corruptedData);

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong during corruption. see info below for details:\n\n{ex.ToString()}");
                    return;
                }
                finally
                {
                    headerForm.Invoke(myDelegate);

                }
            });

            var t = new System.Threading.Thread(pts);
            t.Start();

            

        }

        private byte[] GenerateCorruption(Random rnd)
        {

            //pre-caching the buffer
            byte[] buffer = new byte[RomData.Length];
            Array.Copy(RomData, buffer, RomData.Length);

            for (int i = 0; i < Intensity; i++)
            {

                int address;
                if (UseCustomTargetRange)
                    address = CustomTargetRange.GetRandomValueWithinCustomRange(rnd);
                else
                    address = rnd.Next(0, RomData.Length);

                int value;
                if (UseCustomValueRange)
                    value = CustomValueRange.GetRandomValueWithinCustomRange(rnd);
                else
                    value = rnd.Next(0, 256);


                buffer[address] = (byte)value;
            }

            return buffer;
        }

    }
    public enum WizardStep
    {
        UNINITIALIZED = 0,
        START = 1,
        SELECTROM = 2,
        ENGINECONFIG = 3,
        TARGETSETUP = 4,
        RUNCORRUPT = 5,
        EXECUTE = 6,
        RESET = 7
    }

    public class CustomRange
    {
        public List<int> LoneNumbers = new List<int>();
        public List<int> LowerBoundaries = new List<int>();
        public List<int> UpperBoundaries = new List<int>();

        public CustomRange(string text, bool useRomSize)
        {
            try
            {

                if (text == null || text.Trim() == "")
                {
                    MessageBox.Show("Could not create a Custom Range from a null or empty text string");
                    throw new Exception("HANDLED");
                }

                text = text.Replace(" ", ""); //spaces are meaningless

                text = text.Replace("$", ""); //we're keeping the $ for ourselves

                //transform new lines in $ symbols
                text = text.Replace("\r", "$");
                text = text.Replace("\n", "$");
                text = text.Replace("$$", "$");

                //$ are new lines now
                var textLines = text.Split('$');
                List<string> unescapedLines = new List<string>();
                foreach (var line in textLines)
                {
                    if (line.StartsWith("//")) // we use // as comments
                        continue;

                    if (line == "") //empty lines are legal
                        continue;

                    unescapedLines.Add(line);
                }


                text = String.Join(",", unescapedLines.ToArray());
                var parts = text.Split(',');

                foreach (var part in parts)
                {
                    string cleanPart = part.Trim().ToUpper();

                    if (cleanPart == "")
                        continue;

                    //match for a range
                    var hexRangeRegex = new Regex("^[0-9A-F]*-[0-9A-F]*$");

                    if (cleanPart.Contains("-"))
                    {
                        //has a -, is a range

                        if (!hexRangeRegex.IsMatch(cleanPart))
                        {
                            MessageBox.Show($"Could not validate this range: {cleanPart}");
                            throw new Exception("HANDLED");
                        }

                        var rangeParts = cleanPart.Split('-');
                        int lower = int.Parse(rangeParts[0], System.Globalization.NumberStyles.HexNumber);
                        int upper = int.Parse(rangeParts[1], System.Globalization.NumberStyles.HexNumber);

                        if (upper <= lower)
                        {
                            MessageBox.Show($"Error with this part: {cleanPart}\n Cannot have ranges with zero or negative values");
                            throw new Exception("HANDLED");
                        }

                        if (!useRomSize && upper > 255)
                        {
                            //assume that if we're not using the rom size, we're looking for ranges within a byte's possible values

                            MessageBox.Show($"Error with this part: {cleanPart}\n Cannot have values higher than 255");
                            throw new Exception("HANDLED");
                        }

                        if (useRomSize && upper >= WizardOrchestrator.Session.RomData.Length)
                        {
                            //value is OOB from rom

                            MessageBox.Show($"Error with this part: {cleanPart}\n Range is going higher than ROM size");
                            throw new Exception("HANDLED");
                        }

                        //adding boundaries in pairs to both lists (matching index)
                        LowerBoundaries.Add(lower);
                        UpperBoundaries.Add(upper);
                    }
                    else
                    {
                        //lone number

                        int intValue = int.Parse(cleanPart, System.Globalization.NumberStyles.HexNumber);

                        if (!useRomSize && intValue > 255)
                        {
                            //assume that if we're not using the rom size, we're looking for ranges within a byte's possible values

                            MessageBox.Show($"Error with this part: {cleanPart}\n Cannot have values higher than 255");
                            throw new Exception("HANDLED");
                        }

                        if (useRomSize && intValue >= WizardOrchestrator.Session.RomData.Length)
                        {
                            //value is OOB from rom
                            MessageBox.Show($"Error with this part: {cleanPart}\n Address is higher than ROM size");
                        }

                        LoneNumbers.Add(intValue);
                    }
                }


            }
            catch (Exception ex)
            {
                if (!ex.ToString().Contains("HANDLED"))
                {
                    MessageBox.Show($"Something terribly wrong happen when parsing the CustomRange object from text values\n\n{ex.ToString()}");
                }

                throw;
            }

        }

        public int GetCustomRangeSize()
        {
            //get the full virtual range size including all lone numbers and ranges

            int size = 0;

            size += LoneNumbers.Count;

            for (int i = 0; i < LowerBoundaries.Count; i++)
            {
                var lowerBoundary = LowerBoundaries[i];
                var upperBoundary = UpperBoundaries[i];
                int rangeSize = upperBoundary - lowerBoundary;

                size += rangeSize;
            }

            return size;
        }

        public int GetRandomValueWithinCustomRange(Random rnd = null)
        {
            if (rnd == null)
                rnd = new Random((int)DateTime.Now.Ticks);


            int rangeSize = GetCustomRangeSize(); //get the full virtual range size
            int rangePosition = rnd.Next(0, rangeSize); //get a location within virtual range size

            //did we fall on a lone number?
            if (rangePosition < LoneNumbers.Count)
            {
                //bingo, return the lone number
                return LoneNumbers[rangePosition];
            }

            int driftPosition = rangePosition - LoneNumbers.Count;

            //the drift position will decrease as the iterator goes through the ranges.
            //when the position eventually falls within the boundaries of one of the ranges, it will return the value

            for (int i = 0; i < LowerBoundaries.Count; i++)
            {
                var lowerBoundary = LowerBoundaries[i];
                var upperBoundary = UpperBoundaries[i];
                int boundarySize = upperBoundary - lowerBoundary;

                if (driftPosition < boundarySize)
                {
                    //we're in the right spot, return the value
                    return LowerBoundaries[i] + driftPosition;
                }
                else
                {
                    //it's somewhere else. shift the drifting position
                    driftPosition -= boundarySize;
                }
            }

            //if the algorithm works correctly, this should never be hit.
            throw new Exception("ILLEGAL RANGE, THIS SHOULD BE IMPOSSIBLE");

        }
    }

    public interface IValidatable
    {
        bool Validate();
    }
}
