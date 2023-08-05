namespace SSRC
{
    partial class WizardFooter
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
            this.SuspendLayout();
            // 
            // lbCurrentStep
            // 
            this.lbCurrentStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbCurrentStep.ForeColor = System.Drawing.Color.DarkGray;
            this.lbCurrentStep.Location = new System.Drawing.Point(12, 1);
            this.lbCurrentStep.Name = "lbCurrentStep";
            this.lbCurrentStep.Size = new System.Drawing.Size(396, 18);
            this.lbCurrentStep.TabIndex = 0;
            this.lbCurrentStep.Text = "Super Simple ROM Corruptor";
            this.lbCurrentStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "v1.00 - Written by Ircluzar - 2022";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WizardFooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(420, 42);
            this.Controls.Add(this.lbCurrentStep);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WizardFooter";
            this.Text = "WizardHeader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCurrentStep;
        private System.Windows.Forms.Label label1;
    }
}