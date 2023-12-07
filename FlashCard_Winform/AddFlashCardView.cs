using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace FlashCard_Winform
{
    public partial class AddFlashCardView : Form
    {
        private const string baseUrl = "http://api.mymemory.translated.net";
        private HttpClient httpClient;

        private async void  Translate_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                string translatedText = await TranslateAsync(Source.Text, SourceLang.SelectedItem.ToString(), TargetLang.SelectedItem.ToString());
                Target.Text = translatedText;
                Form1 form1 = Application.OpenForms["Form1"] as Form1;
                if (form1 != null)
                {
                    form1.UpdateDataGridView(Source.Text, Target.Text);
                }
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Translation failed. Please try again. The error is"+" "+ exception);
            }
        }
        private async Task<string> TranslateAsync(string text, string sourceLang, string targetLang)
        {
            string url = $"{baseUrl}/get?q={Uri.EscapeDataString(text)}&langpair={sourceLang}|{targetLang}";
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);
            if (result.responseStatus == 200)
            {
                string decodedText = WebUtility.HtmlDecode(result.translatedText);
                return decodedText; 
            }
            return string.Empty;
        }

        private void AddFlashCardView_Load(object sender, EventArgs e)
        {
            SourceLang.Items.AddRange(new string[] { "en", "vi", "fr", "ja", "ko", "zh" });
            TargetLang.Items.AddRange(new string[] { "en", "vi", "fr", "ja", "ko", "zh" });
            SourceLang.SelectedIndex = 0;
            TargetLang.SelectedIndex = 1;
        }

        public AddFlashCardView()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }
    }
    public class TranslationResponse
    {
        [JsonProperty("responseStatus")]
        public int responseStatus { get; set; }

        [JsonProperty("responseData")]
        public TranslationData responseData { get; set; }

        public string translatedText => responseData?.TranslationText;
    }
    public class TranslationData
    {
        [JsonProperty("translatedText")]
        public string TranslationText { get; set; }
    }
}
