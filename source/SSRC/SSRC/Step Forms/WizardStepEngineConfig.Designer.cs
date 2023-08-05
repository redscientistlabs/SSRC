namespace SSRC
{
    partial class WizardStepEngineConfig
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
            this.label2 = new System.Windows.Forms.Label();
            this.rbEntireRange = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSelectRange = new System.Windows.Forms.RadioButton();
            this.tbSpecificRanges = new System.Windows.Forms.TextBox();
            this.nmIntensity = new System.Windows.Forms.NumericUpDown();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmIntensity)).BeginInit();
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
            this.lbCurrentStep.Text = "Time to prepare the engine for corruption. ";
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of bytes to corrupt:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbEntireRange
            // 
            this.rbEntireRange.AutoSize = true;
            this.rbEntireRange.Checked = true;
            this.rbEntireRange.Location = new System.Drawing.Point(33, 130);
            this.rbEntireRange.Name = "rbEntireRange";
            this.rbEntireRange.Size = new System.Drawing.Size(112, 17);
            this.rbEntireRange.TabIndex = 9;
            this.rbEntireRange.TabStop = true;
            this.rbEntireRange.Text = "Entire range (0-FF)";
            this.rbEntireRange.UseVisualStyleBackColor = true;
            this.rbEntireRange.CheckedChanged += new System.EventHandler(this.RangeOptions_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(31, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Values to be used for corruption:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbSelectRange
            // 
            this.rbSelectRange.AutoSize = true;
            this.rbSelectRange.Location = new System.Drawing.Point(33, 151);
            this.rbSelectRange.Name = "rbSelectRange";
            this.rbSelectRange.Size = new System.Drawing.Size(156, 17);
            this.rbSelectRange.TabIndex = 11;
            this.rbSelectRange.Text = "Specific ranges and values:";
            this.rbSelectRange.UseVisualStyleBackColor = true;
            this.rbSelectRange.CheckedChanged += new System.EventHandler(this.RangeOptions_CheckedChanged);
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
            this.tbSpecificRanges.TabIndex = 12;
            // 
            // nmIntensity
            // 
            this.nmIntensity.BackColor = System.Drawing.Color.Black;
            this.nmIntensity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nmIntensity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nmIntensity.Location = new System.Drawing.Point(173, 82);
            this.nmIntensity.Maximum = new decimal(new int[] {
            42069420,
            0,
            0,
            0});
            this.nmIntensity.Name = "nmIntensity";
            this.nmIntensity.Size = new System.Drawing.Size(84, 17);
            this.nmIntensity.TabIndex = 13;
            this.nmIntensity.Value = new decimal(new int[] {
            69,
            0,
            0,
            0});
            this.nmIntensity.ValueChanged += new System.EventHandler(this.nmIntensity_ValueChanged);
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
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // WizardStepEngineConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(420, 269);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.nmIntensity);
            this.Controls.Add(this.tbSpecificRanges);
            this.Controls.Add(this.rbSelectRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbEntireRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbCurrentStep);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WizardStepEngineConfig";
            this.Text = "WizardHeader";
            ((System.ComponentModel.ISupportInitialize)(this.nmIntensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrentStep;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbEntireRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSelectRange;
        private System.Windows.Forms.TextBox tbSpecificRanges;
        private System.Windows.Forms.NumericUpDown nmIntensity;
        private System.Windows.Forms.Button btnHelp;
    }
}