using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AutoClicker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Timer tt = null;
        int currenX = 0;
        int currenY = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            tt = new Timer() { Interval = 10, Enabled = true };
            tt.Tick += (ss, ee) =>
            {
                currenX = Control.MousePosition.X;
                currenY = Control.MousePosition.Y;
                label1.Text = currenX + " : " + currenY;
            };
        }
    }
}
