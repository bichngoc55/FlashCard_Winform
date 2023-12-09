using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard_Winform
{
    public partial class FlashCardView : Form
    {
        private string data2;
        public FlashCardView(string text1,string text2)
        {
            InitializeComponent();
            SourceText.Text = text1;
            data2= text2;

        }

        private void ShowAnswer_Click(object sender, EventArgs e)
        {
            TargetText.Text = data2; 
        }

        private void RateText_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                form1.MarkResult(SourceText.Text, InputText.Text);
            }
            this.Close();
        }
    }
}
