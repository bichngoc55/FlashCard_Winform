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
        private int CurrentRowIndex;
        private string defaultText = "Nhập nghĩa của từ";
        public FlashCardView(string text1,string text2,int index)
        {
            InitializeComponent();
            InputText.Focus();
            SourceText.Text = text1;
            data2= text2;
            CurrentRowIndex = index;
             
        }
       
        private void ShowAnswer_Click(object sender, EventArgs e)
        {
            TargetText.Text = data2; 
        }

        private void RateText_Click(object sender, EventArgs e)
        {
            TargetText.Text= data2;
            var TargetOriginally = TargetText.Text.ToLower();
            var Inputoriginally = InputText.Text.ToLower();
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                if (TargetOriginally == Inputoriginally)
                {
                    MessageBox.Show("Correct Answer");
                    form1.MarkResult(SourceText.Text, InputText.Text);
                    
                }
                else
                {
                    MessageBox.Show("Wrong Answer");
                     
                } 
            }
            
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            { 
                if (CurrentRowIndex < form1.SiticoneDataGridView1.Rows.Count - 2)
                {
                    DataGridViewRow nextRow = form1.SiticoneDataGridView1.Rows[CurrentRowIndex + 1];
                    string text1 = nextRow.Cells[1].Value.ToString();  
                    string text2 = nextRow.Cells[2].Value.ToString();  
                    CurrentRowIndex++;

                    
                    SourceText.Text = text1;
                    InputText.Text = "Nhập nghĩa của từ";
                    data2 = text2;
                    TargetText.Text = "Đáp án";  
                }
                else
                {
                    MessageBox.Show("Không còn flashcard nào nữa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                if (CurrentRowIndex >=1)
                {
                    DataGridViewRow nextRow = form1.SiticoneDataGridView1.Rows[CurrentRowIndex - 1];
                    string text1 = nextRow.Cells[1].Value.ToString();
                    string text2 = nextRow.Cells[2].Value.ToString();
                    CurrentRowIndex--;


                    SourceText.Text = text1;
                    InputText.Text = "Nhập nghĩa của từ";
                    data2= text2;
                    TargetText.Text = "Đáp án";
                }
                else
                {
                    MessageBox.Show("Không còn flashcard nào nữa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
            if (InputText.Text == defaultText)
            {
                InputText.Text = string.Empty;
            }
        }
    }
}
