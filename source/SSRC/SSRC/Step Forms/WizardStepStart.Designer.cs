namespace SSRC
{
    partial class WizardStepStart
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.pb140 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb140)).BeginInit();
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
            this.lbCurrentStep.Text = "Welcome to the Super Simple ROM Corruptor. This corruptor will guide you step by " +
    "step and generate ROM corruptions based on the settings you input.";
            this.lbCurrentStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "When you are ready to start, press the Next button.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pb140
            // 
            this.pb140.BackgroundImage = global::SSRC.Properties.Resources._140;
            this.pb140.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb140.Location = new System.Drawing.Point(12, 86);
            this.pb140.Name = "pb140";
            this.pb140.Size = new System.Drawing.Size(396, 140);
            this.pb140.TabIndex = 3;
            this.pb140.TabStop = false;
            this.pb140.Click += new System.EventHandler(this.pb140_Click);
            // 
            // WizardStepStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(420, 269);
            this.Controls.Add(this.pb140);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCurrentStep);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WizardStepStart";
            this.Text = "WizardHeader";
            ((System.ComponentModel.ISupportInitialize)(this.pb140)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCurrentStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pb140;
    }
}