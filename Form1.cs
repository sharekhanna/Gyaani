using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using System.Diagnostics;
using System.Globalization;

namespace Gyaani
{
    public partial class Form1 : Form
    {
        
        public String zsign;
        public String task;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Daily Horoscope v1.0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void aries_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "aries";
                if (zsign == "aries")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        


        private void taurus_Click_1(object sender, EventArgs e)
        {
            try
            {
                zsign = "taurus";
                if (zsign == "taurus")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void gemini_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "gemini";
                if (zsign == "gemini")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void cancer_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "cancer";
                if (zsign == "cancer")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void leo_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "leo";
                if (zsign == "leo")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void virgo_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "virgo";
                if (zsign == "virgo")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void libra_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "libra";
                if (zsign == "libra")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void scorpio_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "scorpio";
                if (zsign == "scorpio")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void sagittarius_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "sagittarius";
                if (zsign == "sagittarius")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void capricorn_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "capricorn";
                if (zsign == "capricorn")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void aquarius_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "aquarius";
                if (zsign == "aquarius")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void pisces_Click(object sender, EventArgs e)
        {
            try
            {
                zsign = "pisces";
                if (zsign == "pisces")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime datex = dateTimePicker1.Value.Date;
            datex = DateTime.ParseExact(datex.ToString("MMMM d"), "MMMM d", CultureInfo.InvariantCulture);
            if (datex.Date >= DateTime.ParseExact("March 21", "MMMM d", null) && datex.Date <= DateTime.ParseExact("April 19", "MMMM d", null)) { zsign = "Aries".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("April 20", "MMMM d", null) && datex.Date <= DateTime.ParseExact("May 20", "MMMM d", null)) { zsign = "Taurus".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("May 21", "MMMM d", null) && datex.Date <= DateTime.ParseExact("June 21", "MMMM d", null)) { zsign = "Gemini".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("June 22", "MMMM d", null) && datex.Date <= DateTime.ParseExact("July 22", "MMMM d", null)) { zsign = "Cancer".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("July 23", "MMMM d", null) && datex.Date <= DateTime.ParseExact("August 22", "MMMM d", null)) { zsign = "Leo".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("August 23", "MMMM d", null) && datex.Date <= DateTime.ParseExact("September 22", "MMMM d", null)) { zsign = "Virgo".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("September 23", "MMMM d", null) && datex.Date <= DateTime.ParseExact("October 23", "MMMM d", null)) { zsign = "Libra".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("October 24", "MMMM d", null) && datex.Date <= DateTime.ParseExact("November 22", "MMMM d", null)) { zsign = "Scorpio".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("November 23", "MMMM d", null) && datex.Date <= DateTime.ParseExact("December 21", "MMMM d", null)) { zsign = "Sagittarius".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("December 22", "MMMM d", null) && datex.Date <= DateTime.ParseExact("January 19", "MMMM d", null)) { zsign = "Capricorn".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("January 20", "MMMM d", null) && datex.Date <= DateTime.ParseExact("February 18", "MMMM d", null)) { zsign = "Aquarius".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("February 19", "MMMM d", null) && datex.Date <= DateTime.ParseExact("March 20", "MMMM d", null)) { zsign = "Pisces".ToLower(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(zsign)) 
                {
                    MessageBox.Show("Empty Date");
                }
                else
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
