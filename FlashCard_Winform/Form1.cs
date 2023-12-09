﻿using Siticone.Desktop.UI.AnimatorNS;
 
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
        int diem = 0;

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
            addFlashCardView.Owner = this;
            addFlashCardView.StartPosition = FormStartPosition.CenterParent;
            addFlashCardView.Show();
        }


        public void MarkResult(string text1, string text2)
        {
            diem += 10;
            Mark.Text = diem.ToString();
        }

        private void siticoneDataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < siticoneDataGridView1.Rows.Count)
            {
                string text1 = siticoneDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string text2 = siticoneDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


                FlashCardView flashCardView = new FlashCardView(text1, text2);
                flashCardView.StartPosition = FormStartPosition.CenterParent;
                flashCardView.Show();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (siticoneDataGridView1.SelectedRows.Count > 0)
            {
                 
                int selectedIndex = siticoneDataGridView1.SelectedRows[0].Index;

                siticoneDataGridView1.Rows.RemoveAt(selectedIndex);
            }
            else
            {
               
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
