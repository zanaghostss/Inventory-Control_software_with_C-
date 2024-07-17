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
    public partial class Form_eoq : Form
    {
        private object numericUpDown11;

        public Form_eoq()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Dispose();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int q =(int)numericUpDown1.Value;
            int a=(int)numericUpDown2.Value;
            int h=(int)numericUpDown3.Value;
  




            double q1 = Math.Sqrt((2 * q * a) / h);
            double n = q / q1;
            double tc = (h * q1) / 2 + (q * a);
            double to = (q / q1) * a;


            label1.Text = q1.ToString();
            label2.Text = n.ToString();
            label3.Text = tc.ToString();
            label4.Text = to.ToString();
        }

        private void Form_eoq_Load(object sender, EventArgs e)
        {

        }
    }
}
