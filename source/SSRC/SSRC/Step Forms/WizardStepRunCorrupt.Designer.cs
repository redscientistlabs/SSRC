namespace SSRC
{
    partial class WizardStepRunCorrupt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCurrentStep = new System.Windows.Forms.Label();
            this.btnCorrupt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbExecuteWithEmu = new System.Windows.Forms.RadioButton();
            this.rbCreateCorrupted = new System.Windows.Forms.RadioButton();
            this.rbCreateMultiple = new System.Windows.Forms.RadioButton();
            this.btnBrowseEmu = new System.Windows.Forms.Button();
            this.tbEmuPath = new System.Windows.Forms.TextBox();
            this.nmAmountCorrupted = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCorruptedFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.cbFilenameGuid = new System.Windows.Forms.CheckBox();
            this.cbAutoKill = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmAmountCorrupted)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCurrentStep
            // 
            this.lbCurrentStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentStep.ForeColor = System.Drawing.Color.DarkGray;
            this.lbCurrentStep.Location = new System.Drawing.Point(11, 4);
            this.lbCurrentStep.Name = "lbCurrentStep";
            this.lbCurrentStep.Size = new System.Drawing.Size(396, 70);
            this.lbCurrentStep.TabIndex = 0;
            this.lbCurrentStep.Text = "The corruptor can load the corrupted ROM in an emulator. Alternatively, it can ge" +
    "nerate one or multiple corruptions at once.";
            this.lbCurrentStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCorrupt
            // 
            this.btnCorrupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnCorrupt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCorrupt.FlatAppearance.BorderSize = 0;
            this.btnCorrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrupt.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCorrupt.Location = new System.Drawing.Point(334, 232);
            this.btnCorrupt.Name = "btnCorrupt";
            this.btnCorrupt.Size = new System.Drawing.Size(74, 28);
            this.btnCorrupt.TabIndex = 2;
            this.btnCorrupt.Text = "Corrupt";
            this.btnCorrupt.UseVisualStyleBackColor = false;
            this.btnCorrupt.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Corruption method:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbExecuteWithEmu
            // 
            this.rbExecuteWithEmu.AutoSize = true;
            this.rbExecuteWithEmu.Checked = true;
            this.rbExecuteWithEmu.Location = new System.Drawing.Point(15, 99);
            this.rbExecuteWithEmu.Name = "rbExecuteWithEmu";
            this.rbExecuteWithEmu.Size = new System.Drawing.Size(247, 17);
            this.rbExecuteWithEmu.TabIndex = 18;
            this.rbExecuteWithEmu.TabStop = true;
            this.rbExecuteWithEmu.Text = "Create corrupted file and execute with emulator";
            this.rbExecuteWithEmu.UseVisualStyleBackColor = true;
            this.rbExecuteWithEmu.CheckedChanged += new System.EventHandler(this.CorruptionMethod_CheckedChanged);
            // 
            // rbCreateCorrupted
            // 
            this.rbCreateCorrupted.AutoSize = true;
            this.rbCreateCorrupted.Location = new System.Drawing.Point(15, 143);
            this.rbCreateCorrupted.Name = "rbCreateCorrupted";
            this.rbCreateCorrupted.Size = new System.Drawing.Size(323, 17);
            this.rbCreateCorrupted.TabIndex = 20;
            this.rbCreateCorrupted.Text = "Create corrupted file next to original file (filename_corrupted.ext)";
            this.rbCreateCorrupted.UseVisualStyleBackColor = true;
            this.rbCreateCorrupted.CheckedChanged += new System.EventHandler(this.CorruptionMethod_CheckedChanged);
            // 
            // rbCreateMultiple
            // 
            this.rbCreateMultiple.AutoSize = true;
            this.rbCreateMultiple.Location = new System.Drawing.Point(15, 164);
            this.rbCreateMultiple.Name = "rbCreateMultiple";
            this.rbCreateMultiple.Size = new System.Drawing.Size(163, 17);
            this.rbCreateMultiple.TabIndex = 21;
            this.rbCreateMultiple.Text = "Create multiple corrupted files";
            this.rbCreateMultiple.UseVisualStyleBackColor = true;
            this.rbCreateMultiple.CheckedChanged += new System.EventHandler(this.CorruptionMethod_CheckedChanged);
            // 
            // btnBrowseEmu
            // 
            this.btnBrowseEmu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowseEmu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowseEmu.FlatAppearance.BorderSize = 0;
            this.btnBrowseEmu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseEmu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnBrowseEmu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBrowseEmu.Location = new System.Drawing.Point(313, 95);
            this.btnBrowseEmu.Name = "btnBrowseEmu";
            this.btnBrowseEmu.Size = new System.Drawing.Size(95, 21);
            this.btnBrowseEmu.TabIndex = 23;
            this.btnBrowseEmu.Text = "Browse Emulator";
            this.btnBrowseEmu.UseVisualStyleBackColor = false;
            this.btnBrowseEmu.Click += new System.EventHandler(this.btnBrowseEmu_Click);
            // 
            // tbEmuPath
            // 
            this.tbEmuPath.BackColor = System.Drawing.Color.Black;
            this.tbEmuPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmuPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbEmuPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbEmuPath.Location = new System.Drawing.Point(14, 122);
            this.tbEmuPath.Name = "tbEmuPath";
            this.tbEmuPath.Size = new System.Drawing.Size(394, 14);
            this.tbEmuPath.TabIndex = 22;
            this.tbEmuPath.TextChanged += new System.EventHandler(this.tbEmuPath_TextChanged);
            // 
            // nmAmountCorrupted
            // 
            this.nmAmountCorrupted.BackColor = System.Drawing.Color.Black;
            this.nmAmountCorrupted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmAmountCorrupted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nmAmountCorrupted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nmAmountCorrupted.Location = new System.Drawing.Point(223, 180);
            this.nmAmountCorrupted.Maximum = new decimal(new int[] {
            69420,
            0,
            0,
            0});
            this.nmAmountCorrupted.Name = "nmAmountCorrupted";
            this.nmAmountCorrupted.Size = new System.Drawing.Size(67, 17);
            this.nmAmountCorrupted.TabIndex = 25;
            this.nmAmountCorrupted.Value = new decimal(new int[] {
            420,
            0,
            0,
            0});
            this.nmAmountCorrupted.ValueChanged += new System.EventHandler(this.nmAmountCorrupted_ValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(31, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amount of corrupted files to generate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCorruptedFolder
            // 
            this.tbCorruptedFolder.BackColor = System.Drawing.Color.Black;
            this.tbCorruptedFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCorruptedFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbCorruptedFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbCorruptedFolder.Location = new System.Drawing.Point(12, 246);
            this.tbCorruptedFolder.Name = "tbCorruptedFolder";
            this.tbCorruptedFolder.Size = new System.Drawing.Size(294, 14);
            this.tbCorruptedFolder.TabIndex = 26;
            this.tbCorruptedFolder.TextChanged += new System.EventHandler(this.tbCorruptedFolder_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(11, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Path to target folder for corrupted files:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowseFolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowseFolder.FlatAppearance.BorderSize = 0;
            this.btnBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnBrowseFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBrowseFolder.Location = new System.Drawing.Point(223, 222);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(83, 21);
            this.btnBrowseFolder.TabIndex = 28;
            this.btnBrowseFolder.Text = "Browse Folder";
            this.btnBrowseFolder.UseVisualStyleBackColor = false;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // cbFilenameGuid
            // 
            this.cbFilenameGuid.AutoSize = true;
            this.cbFilenameGuid.Location = new System.Drawing.Point(13, 209);
            this.cbFilenameGuid.Name = "cbFilenameGuid";
            this.cbFilenameGuid.Size = new System.Drawing.Size(142, 17);
            this.cbFilenameGuid.TabIndex = 29;
            this.cbFilenameGuid.Text = "Use GUIDs for filenames";
            this.cbFilenameGuid.UseVisualStyleBackColor = true;
            this.cbFilenameGuid.CheckedChanged += new System.EventHandler(this.cbFilenameGuid_CheckedChanged);
            // 
            // cbAutoKill
            // 
            this.cbAutoKill.Checked = true;
            this.cbAutoKill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoKill.Location = new System.Drawing.Point(335, 187);
            this.cbAutoKill.Name = "cbAutoKill";
            this.cbAutoKill.Size = new System.Drawing.Size(75, 35);
            this.cbAutoKill.TabIndex = 31;
            this.cbAutoKill.Text = "Kill Emu on Corrupt";
            this.cbAutoKill.UseVisualStyleBackColor = true;
            this.cbAutoKill.CheckedChanged += new System.EventHandler(this.cbAutoKill_CheckedChanged);
            // 
            // WizardStepRunCorrupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(420, 269);
            this.Controls.Add(this.btnBrowseEmu);
            this.Controls.Add(this.cbAutoKill);
            this.Controls.Add(this.cbFilenameGuid);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.tbCorruptedFolder);
            this.Controls.Add(this.nmAmountCorrupted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmuPath);
            this.Controls.Add(this.rbCreateMultiple);
            this.Controls.Add(this.rbCreateCorrupted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbExecuteWithEmu);
            this.Controls.Add(this.btnCorrupt);
            this.Controls.Add(this.lbCurrentStep);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WizardStepRunCorrupt";
            this.Text = "WizardHeader";
            this.Load += new System.EventHandler(this.WizardStepRunCorrupt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmAmountCorrupted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrentStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbExecuteWithEmu;
        private System.Windows.Forms.RadioButton rbCreateCorrupted;
        private System.Windows.Forms.RadioButton rbCreateMultiple;
        private System.Windows.Forms.Button btnBrowseEmu;
        private System.Windows.Forms.TextBox tbEmuPath;
        private System.Windows.Forms.NumericUpDown nmAmountCorrupted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCorruptedFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.CheckBox cbFilenameGuid;
        private System.Windows.Forms.CheckBox cbAutoKill;
        public System.Windows.Forms.Button btnCorrupt;
    }
}