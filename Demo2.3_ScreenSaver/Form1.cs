using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2._3_ScreenSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int delX = 2;
        int delY = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Left += delX;
            this.label1.Top += delY;
            if (this.label1.Left < 0 || this.label1.Left + this.label1.Width > this.Width)
            { delX = -delX; }
            if (this.label1.Top < 0 || this.label1.Top + this.label1.Height > this.Height)
            { delY = -delY; }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}
