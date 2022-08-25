using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimingMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int countMili = 0;
        private int countSec = 0;
        private int countMin = 0;
        private int countHour = 0;
        private void Reset_Click(object sender, EventArgs e)
        {
            ClockTick.Stop();
            Start.Enabled = true;
            countMili = 0;
            countSec = 0;
            countHour = 0;
            countMin = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            ClockTick.Start();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            Start.Enabled = false;
        }

        private void ClockTick_Tick(object sender, EventArgs e)
        {
            countMili++;
            textBox4.Text = countMili.ToString();
            if(countMili == 10)
            {
                countMili = 0;
                textBox4.Text = "0";
                countSec++;
                if(countSec == 60)
                {
                    countSec = 0;
                    textBox3.Text = "0";
                    countMin++;
                    if(countMin == 60)
                    {
                        countMin = 0;
                        textBox2.Text = "0";
                        countHour++;
                        if(countHour == 24)
                        {
                            MessageBox.Show("Over the time of a day. Restart for continuing count");
                        }
                        else
                        {
                            textBox1.Text = countHour.ToString();
                        }
                    }
                    else
                    {
                        textBox2.Text = countMin.ToString();
                    }
                    
                }
                else
                {
                    textBox3.Text = countSec.ToString();
                }
            }
            else
            {
                textBox4.Text = countMili.ToString();
            }
        }
    }
}
