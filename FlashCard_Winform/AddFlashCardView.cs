using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using Google.Cloud.Translation.V2; 
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;

namespace FlashCard_Winform
{
    public partial class AddFlashCardView : Form
    {


        private TranslationClient translationClient;
        private string defaultText = "Nhập từ vựng";
        private void InitializeTranslationClient()
        {
            var credentialsPath = "E:\\C#\\FlashCard_Winform\\FlashCard_Winform\\Resources\\ultra-airway-407519-2e04390ef407.json";
            var credentials = GoogleCredential.FromFile(credentialsPath);
             translationClient = TranslationClient.Create(credentials);
        }

        public AddFlashCardView()
        {
            InitializeComponent();
            InitializeTranslationClient();
            InitializeLanguageComboBoxes();
        }
        private void InitializeLanguageComboBoxes()
        { 
            SourceLang.SelectedIndex = 0;
            TargetLang.SelectedIndex = 1;
        }

        private void Translate_Click(object sender, EventArgs e)
        {
             
            try
            {
                string sourceText = Source.Text;
                string sourceLanguage = GetLanguageCode(SourceLang.SelectedItem.ToString());
                string targetLanguage = GetLanguageCode(TargetLang.SelectedItem.ToString());
  

                var response = translationClient.TranslateText(sourceText, targetLanguage, sourceLanguage);
                Target.Text = response.TranslatedText; 
                Form1 form1 = Application.OpenForms["Form1"] as Form1;
                if (form1 != null)
                {
                    form1.UpdateDataGridView(Source.Text, Target.Text);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Translation error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetLanguageCode(string language)
        {
            switch (language)
            {
                case "English":
                    return "en";
                case "Vietnamese":
                    return "vi";
                case "French":
                    return "fr";
                case "Japanese":
                    return "ja";
                case "Korean":
                    return "ko";
                case "Chinese":
                    return "zh";
                default:
                    return language; 
            }
        }

        private void Source_TextChanged(object sender, EventArgs e)
        {
            if (Source.Text == ""|| int.TryParse(Source.Text, out _)|| double.TryParse(Source.Text, out _))
            { 
                Translate.Enabled = false;
                if (Source.Text == defaultText)
                {
                    Source.Text = string.Empty;
                }

            }
            else
            { 
                Translate.Enabled = true;
            }
        }
    }
    

  }
