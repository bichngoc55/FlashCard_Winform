﻿using System;
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
    public partial class FlashCardView : Form1
    {
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        private void ShowMeaning_Click(object sender, EventArgs e)
        {

            Target.Visible = true;
        }

        public FlashCardView(string text1, string text2)
        {
            InitializeComponent();
            Text1 = text1;
            Text2 = text2;
        }
    }
}
