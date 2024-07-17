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
    public partial class Form_epq : Form
    {
        public Form_epq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = (double)numericUpDown1.Value;
            double a= (double)numericUpDown2.Value;
            double h= (double)numericUpDown3.Value;
            double p= (double)numericUpDown4.Value;
            double dd= (double)numericUpDown5.Value;

            double q_ = Math.Sqrt(2 * d * a / h)*Math.Sqrt(p/p-d);
            double k_=Math.Sqrt(2*d*a*h)*Math.Sqrt(p/p-d);

            label7.Text=q_.ToString();
            label6.Text=k_.ToString();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            

        }
    }
}
