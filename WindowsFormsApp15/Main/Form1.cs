using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Main;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_eoq form_Eoq = new Form_eoq();
            form_Eoq.ShowDialog();
            this.Dispose();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_epq form_Epq = new Form_epq();
            form_Epq.ShowDialog();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            epq_with_shortage epq_With_Shortage = new epq_with_shortage();
            epq_With_Shortage.ShowDialog();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            eoq_with_shortage eoq_With_= new eoq_with_shortage();
            eoq_With_.ShowDialog();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ََabout form_=new Form_ََabout();
            form_.ShowDialog();
            this.Dispose();
        }
    }
}
