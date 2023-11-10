using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_Yapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = {"a","b","c","d","e","f","g","h" };
            string[] sembol2 = { "I","J","K","L","M","N","P","Q","R","S","T","U","V","W","X","Y","Z"};
            string[] sembol3 = {"-","*","/","#","?" };

            Random random= new Random();
            int s1, s2, s3, s4, s5;
            s1 = random.Next(0, sembol2.Length);
            s2= random.Next(0, 10);
            s3= random.Next(0, sembol3.Length);
            s4=random.Next(0, 10);
            s5 = random.Next(0, sembol1.Length);

            label1.Text=  sembol2[s1].ToString() + s2.ToString() + sembol3[s3].ToString() + sembol1[s5].ToString() + s4.ToString();
            
        }
    }
}
