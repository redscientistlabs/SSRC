using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SSRC
{
    [Serializable]
    public class SSRC_Config
    {
        public string EmuPath { get; set; } = null;
        public string RomPath { get; set; } = null;

        public static string configFile = "SSRC.dat";

        public static SSRC_Config CurrentConfig = null;
        public static void LoadConfig()
        {
            //load serialized file
            if(File.Exists(configFile))
            {
                try
                {

                BinaryFormatter b = new BinaryFormatter();
                var data = File.ReadAllBytes(configFile);
                var ms = new MemoryStream(data);
                var conf = (SSRC_Config)b.Deserialize(ms);
                CurrentConfig = conf;

                }
                catch
                {
                    //fallback
                    CurrentConfig = new SSRC_Config();
                }
            }
            else
            {
                //fallback
                CurrentConfig = new SSRC_Config();
            }

        }

        public static void SaveConfig()
        {
            if (CurrentConfig == null)
                return;

            if (WizardOrchestrator.Session != null)
            {

                //basic checkup if update is needed

                bool updatedEmuPath = false;
                bool updatedRomPath = false;

                if(!string.IsNullOrEmpty(WizardOrchestrator.Session.EmuPath) && CurrentConfig.EmuPath != WizardOrchestrator.Session.EmuPath)
                {
                    CurrentConfig.EmuPath = WizardOrchestrator.Session.EmuPath;
                    updatedEmuPath = true;
                }

                if(!string.IsNullOrEmpty(WizardOrchestrator.Session.RomPath) && CurrentConfig.RomPath != WizardOrchestrator.Session.RomPath)
                {
                    CurrentConfig.RomPath = WizardOrchestrator.Session.RomPath;
                    updatedRomPath = true;
                }

                if(!updatedEmuPath && !updatedRomPath)
                    return;




                try
                {

                    //save serialized file
                    BinaryFormatter b = new BinaryFormatter();
                    var ms = new MemoryStream();
                    b.Serialize(ms, CurrentConfig);
                    var data = ms.ToArray();

                    File.WriteAllBytes(configFile, data);
                }
                catch { } //eat it

            }

        }
    }
}
