using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace Gyaani
{
    public partial class Form2 : Form
    {
        public String zsign;
        public String xdate;

        public Form2(string zsign)
        {
            InitializeComponent();
            this.Text = "Daily Horoscope v1.0";
            
            var finalResult = call(zsign);
            results.AppendText(finalResult.Result);

            label3.Text = xdate;

            byte[] newBytes = new Byte[] { 169 };
            var encoding = Encoding.GetEncoding(1252);
            string string1 = encoding.GetString(newBytes, 0, newBytes.Length);
            label2.Text = string1+" Ayraa Informatics Inc 2020";

            if (zsign == "aries") { aries.BackgroundImage = Properties.Resources.aries; }
            if (zsign == "taurus") { aries.BackgroundImage = Properties.Resources.taurus; }
            if (zsign == "gemini") { aries.BackgroundImage = Properties.Resources.gemini; }
            if (zsign == "cancer") { aries.BackgroundImage = Properties.Resources.cancer; }
            if (zsign == "leo") { aries.BackgroundImage = Properties.Resources.leo; }
            if (zsign == "virgo") { aries.BackgroundImage = Properties.Resources.virgo; }
            if (zsign == "scorpio") { aries.BackgroundImage = Properties.Resources.scorpio; }
            if (zsign == "sagittarius") { aries.BackgroundImage = Properties.Resources.sagittarius; }
            if (zsign == "capricorn") { aries.BackgroundImage = Properties.Resources.capricorn; }
            if (zsign == "aquarius") { aries.BackgroundImage = Properties.Resources.aquarius; }
            if (zsign == "pisces") { aries.BackgroundImage = Properties.Resources.pisces; }
            
            
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool menuClicked = true;
                if (menuClicked)
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        async Task<string> call(string zsign)
        {
            HttpClient httpClient = new HttpClient();
            using var client = httpClient;
            var response = await client.GetStringAsync("http://ohmanda.com/api/horoscope/"+zsign).ConfigureAwait(false);
            var o = JObject.Parse(response);
            var sign = (string)o["sign"];
            xdate = (string)o["date"];
            var horoscope = (string)o["horoscope"];
            return horoscope;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
