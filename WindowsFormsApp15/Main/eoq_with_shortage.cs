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
    public partial class eoq_with_shortage : Form
    {
        public eoq_with_shortage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = (double)numericUpDown1.Value;
            double a=(double)numericUpDown2.Value;
            double h=(double)numericUpDown3.Value;
            double p=(double)numericUpDown4.Value;
            double dd=(double)numericUpDown5.Value;
            double pw=(double)numericUpDown6.Value;
            double pm=(double)numericUpDown7.Value;

            double mm=Math.Sqrt(2*d*a*h*(1-dd/p));

            if(p*d>=mm) {
                     MessageBox.Show("b*=0 epq go to simple");
            }

            else if(pm*d<mm) {
                MessageBox.Show("q*=0,b*=0");
            }

            else if(p==0 && pw>0)
           {
                double q_=Math.Sqrt(2*d*a/h)*Math.Sqrt(p/p-dd)*Math.Sqrt((pw+h)/p);
                double k_ = Math.Sqrt(2 * d * a * h) * Math.Sqrt((p - dd) / p) * Math.Sqrt(pw / pw + h);

                label1.Text=q_.ToString();
                label2.Text=k_.ToString();

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
