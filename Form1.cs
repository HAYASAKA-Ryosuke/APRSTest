using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using hamradio.ke4pjw;
namespace APRSテスト1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          APRS aprs = new APRS();

        private void button1_Click(object sender, EventArgs e)
        {
            aprs.Parse(textBox1.Text);
            textBox2.Text = "コールサイン:"+aprs.Callsign+"\r\n"+aprs.Latitude+","+aprs.Longitude;
        }
    }
}
