namespace FlashCard_Winform
{
    partial class AddFlashCardView
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
            this.Source = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.Target = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SourceLang = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.TargetLang = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.Translate = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.SuspendLayout();
            // 
            // Source
            // 
            this.Source.Animated = true;
            this.Source.BorderColor = System.Drawing.Color.Gray;
            this.Source.BorderRadius = 10;
            this.Source.BorderThickness = 2;
            this.Source.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Source.DefaultText = "Nhập văn bản/từ vựng";
            this.Source.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Source.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Source.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Source.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Source.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Source.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Source.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Source.ForeColor = System.Drawing.Color.DarkGray;
            this.Source.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Source.Location = new System.Drawing.Point(14, 43);
            this.Source.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Source.Name = "Source";
            this.Source.PasswordChar = '\0';
            this.Source.PlaceholderText = "";
            this.Source.SelectedText = "";
            this.Source.Size = new System.Drawing.Size(314, 191);
            this.Source.TabIndex = 1;
            // 
            // Target
            // 
            this.Target.Animated = true;
            this.Target.BorderColor = System.Drawing.Color.Gray;
            this.Target.BorderRadius = 10;
            this.Target.BorderThickness = 2;
            this.Target.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Target.DefaultText = "";
            this.Target.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Target.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Target.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Target.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Target.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Target.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Target.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Target.ForeColor = System.Drawing.Color.DarkGray;
            this.Target.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Target.Location = new System.Drawing.Point(369, 43);
            this.Target.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Target.Name = "Target";
            this.Target.PasswordChar = '\0';
            this.Target.PlaceholderText = "";
            this.Target.SelectedText = "";
            this.Target.Size = new System.Drawing.Size(314, 191);
            this.Target.TabIndex = 2;
            // 
            // SourceLang
            // 
            this.SourceLang.BackColor = System.Drawing.Color.Transparent;
            this.SourceLang.BorderColor = System.Drawing.Color.Gray;
            this.SourceLang.BorderRadius = 10;
            this.SourceLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SourceLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SourceLang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SourceLang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SourceLang.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.SourceLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SourceLang.ItemHeight = 30;
            this.SourceLang.Items.AddRange(new object[] {
            "Vietnamese",
            "English",
            "French"});
            this.SourceLang.Location = new System.Drawing.Point(91, 276);
            this.SourceLang.Name = "SourceLang";
            this.SourceLang.Size = new System.Drawing.Size(145, 36);
            this.SourceLang.TabIndex = 3;
            // 
            // TargetLang
            // 
            this.TargetLang.BackColor = System.Drawing.Color.Transparent;
            this.TargetLang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TargetLang.BorderRadius = 10;
            this.TargetLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TargetLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetLang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TargetLang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TargetLang.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.TargetLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TargetLang.ItemHeight = 30;
            this.TargetLang.Items.AddRange(new object[] {
            "Vietnamese",
            "English",
            "French"});
            this.TargetLang.Location = new System.Drawing.Point(456, 276);
            this.TargetLang.Name = "TargetLang";
            this.TargetLang.Size = new System.Drawing.Size(145, 36);
            this.TargetLang.TabIndex = 4;
            // 
            // Translate
            // 
            this.Translate.BorderRadius = 10;
            this.Translate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Translate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Translate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Translate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Translate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Translate.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Translate.ForeColor = System.Drawing.Color.White;
            this.Translate.Location = new System.Drawing.Point(263, 358);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(140, 37);
            this.Translate.TabIndex = 6;
            this.Translate.Text = "Dịch";
            this.Translate.Click += new System.EventHandler(this.Translate_ClickAsync);
            // 
            // AddFlashCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.TargetLang);
            this.Controls.Add(this.SourceLang);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.Source);
            this.Name = "AddFlashCardView";
            this.Text = "AddFlashCardView";
            this.Load += new System.EventHandler(this.AddFlashCardView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Source;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Target;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox SourceLang;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox TargetLang;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton Translate;
    }
}