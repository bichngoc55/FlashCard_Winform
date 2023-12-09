using Siticone.Desktop.UI.AnimatorNS;
 
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public DataGridView SiticoneDataGridView1
        {
            get { return siticoneDataGridView1; }
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


                FlashCardView flashCardView = new FlashCardView(text1, text2, e.RowIndex);
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
                ReorderSTT();
            }
            else
            {
               
                MessageBox.Show("Chọn 1 dòng để xóa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ReorderSTT()
        {
            for (int i = 0; i < siticoneDataGridView1.Rows.Count-1; i++)
            { 
                siticoneDataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

   

        private void ExportToCsv(SiticoneDataGridView siticoneDataGridView1, string fileName)
        {
            try
            { 
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    List<string> headers = new List<string>();
                    foreach (DataGridViewColumn column in siticoneDataGridView1.Columns)
                    {
                        headers.Add(column.HeaderText);
                    }
                    sw.WriteLine(string.Join(",", headers)); 
                    foreach (DataGridViewRow row in siticoneDataGridView1.Rows)
                    {
                        List<string> rowData = new List<string>();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            rowData.Add(cell.Value?.ToString() ?? "");
                        }
                        sw.WriteLine(string.Join(",", rowData));
                    }
                }

                MessageBox.Show("Xuất thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
         }

        private void siticoneButton2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Xuất dưới dạng CSV";
            saveFileDialog.FileName = "ExportedData.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCsv(siticoneDataGridView1, saveFileDialog.FileName);
            }
        }
    }
}
