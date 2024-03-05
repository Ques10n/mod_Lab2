using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mod_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double eu_k = 0.05;
        const double us_k = 0.06;
        int i = 0;

        Random random = new Random();

        private void btStart_Click(object sender, EventArgs e)
        {

            /*double eu_rate = (double)edRate.Value;
            double us_rate = (double)edUSRate.Value;
            int days = (int)edDays.Value;*/


            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else {
                /*i = 0;
                double eu_rate = (double)edRate.Value;
                double us_rate = (double)edUSRate.Value;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(0, eu_rate);
                chart1.Series[1].Points.AddXY(0, us_rate);*/
                timer1.Start(); 
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double eu_rate = (double)edRate.Value;
            double us_rate = (double)edUSRate.Value;
            i++;

            eu_rate = eu_rate * (1 + eu_k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(i, eu_rate);

            us_rate = us_rate * (1 + us_k * (random.NextDouble() - 0.5));
            chart1.Series[1].Points.AddXY(i, us_rate);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btRestart_Click(object sender, EventArgs e)
        {
                i = 1;
                double eu_rate = (double)edRate.Value;
                double us_rate = (double)edUSRate.Value;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(0, eu_rate);
                chart1.Series[1].Points.AddXY(0, us_rate);
                timer1.Start();
            

        }
    }
}
