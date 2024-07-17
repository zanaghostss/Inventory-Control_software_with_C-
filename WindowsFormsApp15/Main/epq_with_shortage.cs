using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class epq_with_shortage : Form
    {
        public epq_with_shortage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = (double)numericUpDown1.Value;
            double a = (double)numericUpDown2.Value;
            double h = (double)numericUpDown3.Value;
            double p_w = (double)numericUpDown4.Value;
            double p = (double)numericUpDown5.Value;
            
            double kw=  Math.Sqrt((2 * d * a) / h);

            double qq= Math.Sqrt(((2 * d * a) / h)-(p*d/h*p_w+h*h));

            if (p*d > kw) {
                MessageBox.Show("PD > KW. ,b*= 0.");
            }
            else if (p*d < kw) {
                MessageBox.Show("PD < KW. ,k(Q)*="+p*d+",q*="+qq);
            }

            else if(p*d == kw)
            {
                double q__= kw * Math.Sqrt(p_w + h / p_w);
                double b__ = h * q__ / p_w + h;
                double k__ = Math.Sqrt(2 * d * a * h) * Math.Sqrt(p_w + h / p_w);
                label7.Text = q__.ToString();
                label4.Text=b__.ToString();
                label9.Text=k__.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1(); 
            form.ShowDialog();
            this.Dispose();

        }
    }
}
