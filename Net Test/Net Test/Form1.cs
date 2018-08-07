using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.Cryptography;

namespace Net_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "")
                {
                    MessageBox.Show("Incorrect Password");
                    return;
                }

                WebClient wc = new WebClient();
                string data = (wc.DownloadString("https://staela.net/files/himom.txt"));
                data = data.Substring(0, data.Length - 1);
                string pass = MD5Converter(textBox1.Text); ;

                MessageBox.Show(pass);

                if (data == pass)
                {
                    MessageBox.Show("Password Correct");
                } else
                {
                    MessageBox.Show("Password Incorrect");
                }

            } catch (Exception ex)
            {
            }
        }

        private String MD5Converter (String text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i =1; i < result.Length; i ++)
            {
                str.Append(result[i].ToString("x2"));
            }

            return str.ToString();
        }
    }
}
