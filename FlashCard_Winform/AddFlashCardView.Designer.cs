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
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SuspendLayout();
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Animated = true;
            this.siticoneTextBox1.BorderColor = System.Drawing.Color.Gray;
            this.siticoneTextBox1.BorderRadius = 10;
            this.siticoneTextBox1.BorderThickness = 2;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "Nhập văn bản/từ vựng";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.siticoneTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Location = new System.Drawing.Point(243, 155);
            this.siticoneTextBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(314, 141);
            this.siticoneTextBox1.TabIndex = 1;
            // 
            // AddFlashCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siticoneTextBox1);
            this.Name = "AddFlashCardView";
            this.Text = "AddFlashCardView";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
    }
}