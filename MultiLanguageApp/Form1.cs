using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Reflection.Emit;

namespace MultiLanguageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "English";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string p = "";
            if (comboBox1.Text == "English")
            {
                p = "en";
            }
            else if (comboBox1.Text == "Pashto")
            {
                p = "ps-AF";
            }
            else if(comboBox1.Text =="Dari")
            {
                p = "fa-AF";
            }
            changeLanguage(p);
        }

        private void changeLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            button1.Text = Resources.Resource.button1;
            groupBox1.Text= Resources.Resource.groupBox1;
            label1.Text = Resources.Resource.label1;
            lbl_Password.Text = Resources.Resource.lbl_Password;
            lbl_UserName.Text = Resources.Resource.lbl_UserName;

            if (lang == "ps-AF" || lang == "fa-AF")
            {
                this.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.RightToLeft = RightToLeft.No;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string welcomeMessage = Resources.Resource.WelcomeMessage;
            MessageBox.Show(welcomeMessage);
        }
    }
}
