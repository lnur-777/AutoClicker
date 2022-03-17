using Timer = System.Windows.Forms.Timer;
using System.Windows.Input;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Point> points = null;
        Timer tt = null;
        int index = 0;
        int currenX = 0;
        int currenY = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            points = new List<Point>();
            index = 0;
            currenX = Control.MousePosition.X;
            currenY = Control.MousePosition.Y;
            points.Add(new Point()
            {
                X = 65,
                Y = 85
            });
            points.Add(new Point()
            {
                X = 235,
                Y = 85
            });
            Cursor.Position = points[0];
            MouseEvent.LeftClick();
            Cursor.Position = points[1];
            MouseEvent.LeftClick();
            this.Visible = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //KeyEventArgs ke = (KeyEventArgs)e;
            points = new List<Point>();
            index = 0;
            tt = new Timer() { Interval = 50, Enabled = true };
            tt.Tick += (ss, ee) =>
            {
                currenX = Control.MousePosition.X;
                currenY = Control.MousePosition.Y;
                label1.Text = currenX + " : " + currenY;
                if (!this.Visible)
                {
                    SendKeys.Send("{CAPSLOCK}");
                }
                //if (ke.KeyCode == Keys.Enter)
                //{
                //    MessageBox.Show("Enter pressed");
                //}
            };

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                SendKeys.Send("{CAPSLOCK}");
            }
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.MinimizeBox)
            {
                SendKeys.Send("{CAPSLOCK}");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                points.Add(new Point()
                {
                    X = 1200,
                    Y = 600
                });
                Cursor.Position = points[0];
                MouseEvent.LeftClick();
            }
        }
    }
}