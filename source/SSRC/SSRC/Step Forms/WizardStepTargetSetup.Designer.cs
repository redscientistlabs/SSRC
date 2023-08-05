namespace SSRC
{
    partial class WizardStepTargetSetup
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.tbSpecificRanges = new System.Windows.Forms.TextBox();
            this.rbSelectRange = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbEntireRange = new System.Windows.Forms.RadioButton();
            this.lbTargetSize = new System.Windows.Forms.Label();
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
            this.lbCurrentStep.Text = "You can delimit where the corruption is affecting the ROM by setting up ranges an" +
    "d adresses. Otherwise, the entire ROM will be targetted.";
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
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnHelp.Location = new System.Drawing.Point(307, 148);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(27, 21);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tbSpecificRanges
            // 
            this.tbSpecificRanges.BackColor = System.Drawing.Color.Black;
            this.tbSpecificRanges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSpecificRanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbSpecificRanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbSpecificRanges.Location = new System.Drawing.Point(33, 173);
            this.tbSpecificRanges.Multiline = true;
            this.tbSpecificRanges.Name = "tbSpecificRanges";
            this.tbSpecificRanges.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSpecificRanges.Size = new System.Drawing.Size(301, 84);
            this.tbSpecificRanges.TabIndex = 19;
            // 
            // rbSelectRange
            // 
            this.rbSelectRange.AutoSize = true;
            this.rbSelectRange.Location = new System.Drawing.Point(33, 151);
            this.rbSelectRange.Name = "rbSelectRange";
            this.rbSelectRange.Size = new System.Drawing.Size(173, 17);
            this.rbSelectRange.TabIndex = 18;
            this.rbSelectRange.Text = "Specific ranges and addresses:";
            this.rbSelectRange.UseVisualStyleBackColor = true;
            this.rbSelectRange.CheckedChanged += new System.EventHandler(this.Range_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(31, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Values to be used for corruption:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbEntireRange
            // 
            this.rbEntireRange.AutoSize = true;
            this.rbEntireRange.Checked = true;
            this.rbEntireRange.Location = new System.Drawing.Point(33, 130);
            this.rbEntireRange.Name = "rbEntireRange";
            this.rbEntireRange.Size = new System.Drawing.Size(118, 17);
            this.rbEntireRange.TabIndex = 16;
            this.rbEntireRange.TabStop = true;
            this.rbEntireRange.Text = "Entire range (0-___)";
            this.rbEntireRange.UseVisualStyleBackColor = true;
            this.rbEntireRange.CheckedChanged += new System.EventHandler(this.Range_CheckedChanged);
            // 
            // lbTargetSize
            // 
            this.lbTargetSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbTargetSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTargetSize.Location = new System.Drawing.Point(30, 82);
            this.lbTargetSize.Name = "lbTargetSize";
            this.lbTargetSize.Size = new System.Drawing.Size(377, 18);
            this.lbTargetSize.TabIndex = 15;
            this.lbTargetSize.Text = "Target Size: ___ (hex size 0x___)";
            this.lbTargetSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WizardStepTargetSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(420, 269);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tbSpecificRanges);
            this.Controls.Add(this.rbSelectRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbEntireRange);
            this.Controls.Add(this.lbTargetSize);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbCurrentStep);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WizardStepTargetSetup";
            this.Text = "WizardHeader";
            this.Load += new System.EventHandler(this.WizardStepTargetSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrentStep;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox tbSpecificRanges;
        private System.Windows.Forms.RadioButton rbSelectRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEntireRange;
        private System.Windows.Forms.Label lbTargetSize;
    }
}