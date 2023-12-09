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
            this.TargetText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.RateText = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.InputText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SourceText = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.Next = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.Previous = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.ShowAnswer = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.SuspendLayout();
            // 
            // TargetText
            // 
            this.TargetText.BorderRadius = 10;
            this.TargetText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TargetText.DefaultText = "Đáp án";
            this.TargetText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TargetText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TargetText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TargetText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TargetText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TargetText.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.TargetText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TargetText.Location = new System.Drawing.Point(329, 187);
            this.TargetText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TargetText.Name = "TargetText";
            this.TargetText.PasswordChar = '\0';
            this.TargetText.PlaceholderText = "";
            this.TargetText.SelectedText = "";
            this.TargetText.Size = new System.Drawing.Size(248, 134);
            this.TargetText.TabIndex = 4;
            // 
            // RateText
            // 
            this.RateText.BorderRadius = 20;
            this.RateText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RateText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RateText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RateText.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RateText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RateText.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.RateText.ForeColor = System.Drawing.Color.White;
            this.RateText.Location = new System.Drawing.Point(84, 276);
            this.RateText.Name = "RateText";
            this.RateText.Size = new System.Drawing.Size(180, 45);
            this.RateText.TabIndex = 6;
            this.RateText.Text = "Chấm điểm";
            this.RateText.Click += new System.EventHandler(this.RateText_Click);
            // 
            // InputText
            // 
            this.InputText.BorderRadius = 10;
            this.InputText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputText.DefaultText = "Nhập nghĩa của từ";
            this.InputText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputText.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.InputText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputText.Location = new System.Drawing.Point(329, 13);
            this.InputText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.InputText.Name = "InputText";
            this.InputText.PasswordChar = '\0';
            this.InputText.PlaceholderText = "";
            this.InputText.SelectedText = "";
            this.InputText.Size = new System.Drawing.Size(248, 150);
            this.InputText.TabIndex = 7;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // SourceText
            // 
            this.SourceText.BorderRadius = 10;
            this.SourceText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SourceText.DefaultText = "Nghĩa của từ";
            this.SourceText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SourceText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SourceText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SourceText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SourceText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SourceText.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.SourceText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SourceText.Location = new System.Drawing.Point(53, 13);
            this.SourceText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SourceText.Name = "SourceText";
            this.SourceText.PasswordChar = '\0';
            this.SourceText.PlaceholderText = "";
            this.SourceText.SelectedText = "";
            this.SourceText.Size = new System.Drawing.Size(247, 150);
            this.SourceText.TabIndex = 8;
            // 
            // Next
            // 
            this.Next.BorderRadius = 10;
            this.Next.BorderThickness = 1;
            this.Next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Next.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Next.FillColor = System.Drawing.Color.Transparent;
            this.Next.FillColor2 = System.Drawing.Color.Transparent;
            this.Next.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Next.ForeColor = System.Drawing.Color.Black;
            this.Next.Location = new System.Drawing.Point(585, 168);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(47, 25);
            this.Next.TabIndex = 9;
            this.Next.Text = ">";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.BorderRadius = 10;
            this.Previous.BorderThickness = 1;
            this.Previous.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Previous.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Previous.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Previous.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Previous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Previous.FillColor = System.Drawing.Color.White;
            this.Previous.FillColor2 = System.Drawing.Color.White;
            this.Previous.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Previous.ForeColor = System.Drawing.Color.DimGray;
            this.Previous.Location = new System.Drawing.Point(12, 168);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(45, 25);
            this.Previous.TabIndex = 10;
            this.Previous.Text = "<";
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // ShowAnswer
            // 
            this.ShowAnswer.BorderRadius = 20;
            this.ShowAnswer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShowAnswer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShowAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowAnswer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShowAnswer.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.ShowAnswer.ForeColor = System.Drawing.Color.White;
            this.ShowAnswer.Location = new System.Drawing.Point(84, 214);
            this.ShowAnswer.Name = "ShowAnswer";
            this.ShowAnswer.Size = new System.Drawing.Size(180, 39);
            this.ShowAnswer.TabIndex = 5;
            this.ShowAnswer.Text = "Hiển thị đáp án";
            this.ShowAnswer.Click += new System.EventHandler(this.ShowAnswer_Click);
            // 
            // FlashCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.SourceText);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.RateText);
            this.Controls.Add(this.ShowAnswer);
            this.Controls.Add(this.TargetText);
            this.Name = "FlashCardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlashCardView";
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TargetText;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton RateText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox InputText;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox SourceText;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton Next;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton Previous;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton ShowAnswer;
    }
}