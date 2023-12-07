using Siticone.Desktop.UI.AnimatorNS;
 
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlashCard_Winform
{
    public partial class Form1 : Form
    {
        int count = 0; 
        public Form1()
        {
            InitializeComponent();
            
        }

        public void UpdateDataGridView(string text1, string text2)
        {
            count++;
            // Tạo một ListViewItem và thêm vào ListView
            string[] rowValues = { count.ToString(), text1, text2 };
            siticoneDataGridView1.Rows.Add(rowValues);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            AddFlashCardView addFlashCardView = new AddFlashCardView();
            addFlashCardView.Show();
            addFlashCardView.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
