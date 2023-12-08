namespace FlashCard_Winform
{
    partial class FlashCardView
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
            this.Source = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.Target = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.ShowMeaning = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.SuspendLayout();
            // 
            // Source
            // 
            this.Source.BackColor = System.Drawing.Color.White;
            this.Source.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Source.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Source.Location = new System.Drawing.Point(79, 149);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(112, 23);
            this.Source.TabIndex = 0;
            this.Source.Text = "HEHEHEHHE";
            // 
            // Target
            // 
            this.Target.BackColor = System.Drawing.Color.White;
            this.Target.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Target.Location = new System.Drawing.Point(435, 149);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(112, 23);
            this.Target.TabIndex = 1;
            this.Target.Text = "HEHEHEHHE";
            // 
            // ShowMeaning
            // 
            this.ShowMeaning.BorderRadius = 20;
            this.ShowMeaning.BorderThickness = 1;
            this.ShowMeaning.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShowMeaning.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShowMeaning.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowMeaning.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowMeaning.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShowMeaning.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMeaning.ForeColor = System.Drawing.Color.White;
            this.ShowMeaning.Location = new System.Drawing.Point(227, 221);
            this.ShowMeaning.Name = "ShowMeaning";
            this.ShowMeaning.Size = new System.Drawing.Size(180, 45);
            this.ShowMeaning.TabIndex = 2;
            this.ShowMeaning.Text = "Show Meaning";
            this.ShowMeaning.Click += new System.EventHandler(this.ShowMeaning_Click);
            // 
            // FlashCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowMeaning);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.Source);
            this.Name = "FlashCardView";
            this.Text = "FlashCardView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel Source;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel Target;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton ShowMeaning;
    }
}