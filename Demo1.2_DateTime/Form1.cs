using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1._2_DateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.label1.Left += 10;
            this.Text = DateTime.Now.ToString();
            this.label1.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        Random rnd = new Random();
        int deltx = 20;
        int delty = 20;

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.label1.Left + deltx < 0 || this.label1.Left + this.label1.Width + deltx > this.Width)
            {
                deltx = -deltx;
            }

            this.label1.Left += delty;
            this.label1.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));

            if (this.label2.Width + delty < 0 || this.label2.Width + delty > this.Width)
            {
                delty = -delty;
            }
            this.label2.Width += delty; // why this doesn't work?
            this.label2.BackColor = Color.Green;


        }
    }
}
