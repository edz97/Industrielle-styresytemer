using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class HighAlarm : Form
    {
        
        public string Alarmtext = "Temperature Critical HIGH, failsafe is on";
        public HighAlarm(string alarmtext)
        {
            Alarmtext = alarmtext;
            InitializeComponent();
            textBox1.Text = this.Alarmtext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
