using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamShahafElTarig2
{
    public partial class Form1 : Form
    {
        int d;
        
        const int TIMER_INERVAL = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.loadBar.Increment(1);
            d++;
            percentLbl.Text = d + "%".ToString();
            if (d == 100)
            {
                timer1.Stop();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
