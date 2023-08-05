namespace SSRC
{
    partial class WizardHeader
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
            this.btnStepStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStepSelectRom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEngineConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTargetSetup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRunCorrupt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCurrentStep
            // 
            this.lbCurrentStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbCurrentStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbCurrentStep.Location = new System.Drawing.Point(12, 43);
            this.lbCurrentStep.Name = "lbCurrentStep";
            this.lbCurrentStep.Size = new System.Drawing.Size(396, 23);
            this.lbCurrentStep.TabIndex = 0;
            this.lbCurrentStep.Text = "Current step: Unitialized";
            this.lbCurrentStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStepStart
            // 
            this.btnStepStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStepStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStepStart.FlatAppearance.BorderSize = 0;
            this.btnStepStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStepStart.ForeColor = System.Drawing.Color.Gray;
            this.btnStepStart.Location = new System.Drawing.Point(38, 6);
            this.btnStepStart.Name = "btnStepStart";
            this.btnStepStart.Size = new System.Drawing.Size(50, 36);
            this.btnStepStart.TabIndex = 1;
            this.btnStepStart.Tag = "START";
            this.btnStepStart.Text = "Start";
            this.btnStepStart.UseVisualStyleBackColor = false;
            this.btnStepStart.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(91, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "»";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStepSelectRom
            // 
            this.btnStepSelectRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnStepSelectRom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStepSelectRom.FlatAppearance.BorderSize = 0;
            this.btnStepSelectRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStepSelectRom.ForeColor = System.Drawing.Color.Gray;
            this.btnStepSelectRom.Location = new System.Drawing.Point(113, 6);
            this.btnStepSelectRom.Name = "btnStepSelectRom";
            this.btnStepSelectRom.Size = new System.Drawing.Size(50, 36);
            this.btnStepSelectRom.TabIndex = 3;
            this.btnStepSelectRom.Tag = "SELECTROM";
            this.btnStepSelectRom.Text = "Select ROM";
            this.btnStepSelectRom.UseVisualStyleBackColor = false;
            this.btnStepSelectRom.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(165, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "»";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEngineConfig
            // 
            this.btnEngineConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEngineConfig.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEngineConfig.FlatAppearance.BorderSize = 0;
            this.btnEngineConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEngineConfig.ForeColor = System.Drawing.Color.Gray;
            this.btnEngineConfig.Location = new System.Drawing.Point(187, 6);
            this.btnEngineConfig.Name = "btnEngineConfig";
            this.btnEngineConfig.Size = new System.Drawing.Size(50, 36);
            this.btnEngineConfig.TabIndex = 5;
            this.btnEngineConfig.Tag = "ENGINECONFIG";
            this.btnEngineConfig.Text = "Engine Config";
            this.btnEngineConfig.UseVisualStyleBackColor = false;
            this.btnEngineConfig.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(239, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "»";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTargetSetup
            // 
            this.btnTargetSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnTargetSetup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTargetSetup.FlatAppearance.BorderSize = 0;
            this.btnTargetSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTargetSetup.ForeColor = System.Drawing.Color.Gray;
            this.btnTargetSetup.Location = new System.Drawing.Point(260, 5);
            this.btnTargetSetup.Name = "btnTargetSetup";
            this.btnTargetSetup.Size = new System.Drawing.Size(50, 36);
            this.btnTargetSetup.TabIndex = 7;
            this.btnTargetSetup.Tag = "TARGETSETUP";
            this.btnTargetSetup.Text = "Target Setup";
            this.btnTargetSetup.UseVisualStyleBackColor = false;
            this.btnTargetSetup.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(312, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "»";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRunCorrupt
            // 
            this.btnRunCorrupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRunCorrupt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRunCorrupt.FlatAppearance.BorderSize = 0;
            this.btnRunCorrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunCorrupt.ForeColor = System.Drawing.Color.Gray;
            this.btnRunCorrupt.Location = new System.Drawing.Point(334, 5);
            this.btnRunCorrupt.Name = "btnRunCorrupt";
            this.btnRunCorrupt.Size = new System.Drawing.Size(50, 36);
            this.btnRunCorrupt.TabIndex = 9;
            this.btnRunCorrupt.Tag = "RUNCORRUPT";
            this.btnRunCorrupt.Text = "Run Corrupt";
            this.btnRunCorrupt.UseVisualStyleBackColor = false;
            this.btnRunCorrupt.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // WizardHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(420, 69);
            this.Controls.Add(this.btnRunCorrupt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTargetSetup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEngineConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStepSelectRom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStepStart);
            this.Controls.Add(this.lbCurrentStep);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WizardHeader";
            this.Text = "WizardHeader";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbCurrentStep;
        public System.Windows.Forms.Button btnStepStart;
        public System.Windows.Forms.Button btnStepSelectRom;
        public System.Windows.Forms.Button btnEngineConfig;
        public System.Windows.Forms.Button btnTargetSetup;
        public System.Windows.Forms.Button btnRunCorrupt;
    }
}