namespace SSRC
{
    partial class WizardStepSelectRom
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
            this.btnNext = new System.Windows.Forms.Button();
            this.tbRomPath = new System.Windows.Forms.TextBox();
            this.btnBrowseRom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lbCurrentStep.Text = "Select a ROM to load in the corruptor";
            this.lbCurrentStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnNext.Location = new System.Drawing.Point(358, 232);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 28);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbRomPath
            // 
            this.tbRomPath.BackColor = System.Drawing.Color.Black;
            this.tbRomPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRomPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbRomPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbRomPath.Location = new System.Drawing.Point(12, 138);
            this.tbRomPath.Name = "tbRomPath";
            this.tbRomPath.Size = new System.Drawing.Size(395, 14);
            this.tbRomPath.TabIndex = 3;
            this.tbRomPath.TextChanged += new System.EventHandler(this.tbRomPath_TextChanged);
            // 
            // btnBrowseRom
            // 
            this.btnBrowseRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowseRom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowseRom.FlatAppearance.BorderSize = 0;
            this.btnBrowseRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseRom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnBrowseRom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBrowseRom.Location = new System.Drawing.Point(332, 111);
            this.btnBrowseRom.Name = "btnBrowseRom";
            this.btnBrowseRom.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseRom.TabIndex = 4;
            this.btnBrowseRom.Text = "Browse file";
            this.btnBrowseRom.UseVisualStyleBackColor = false;
            this.btnBrowseRom.Click += new System.EventHandler(this.btnBrowseRom_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Path to ROM file:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WizardStepSelectRom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(420, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseRom);
            this.Controls.Add(this.tbRomPath);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbCurrentStep);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WizardStepSelectRom";
            this.Text = "WizardHeader";
            this.Load += new System.EventHandler(this.WizardStepSelectRom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrentStep;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbRomPath;
        private System.Windows.Forms.Button btnBrowseRom;
        private System.Windows.Forms.Label label2;
    }
}