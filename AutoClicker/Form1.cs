using Timer = System.Windows.Forms.Timer;
using System.Windows.Input;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        ClickRound cr=null;
        public Form1()
        {
            InitializeComponent();
        }

        Timer tt = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            cr = new ClickRound();
            Clipboard.Clear();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && string.IsNullOrEmpty(Clipboard.GetText()))
            {
                int second = 1;
                tt = new Timer() { Interval = 1000, Enabled = true };
                tt.Tick += (ss, ee) =>
                {
                    label1.Text = second.ToString();
                    second++;
                };
                cr.FirstRound();
            }
            else if (e.KeyCode == Keys.Enter && Clipboard.GetText() == "passed1")
            {
                cr.SecondRound(textBox1.Text);
                textBox1.Text = "";
            }
            else if (e.KeyCode == Keys.Enter && Clipboard.GetText() == "passed2")
            {
                cr.ThirdRound();
            }
            else if (e.KeyCode == Keys.Enter && Clipboard.GetText() == "passed3")
            {
                cr.FourthRound(textBox1.Text);
                textBox1.Text = "";
            }
            else if (e.KeyCode == Keys.Enter && Clipboard.GetText() == "passed4")
            {
                cr.FifthRound();
                tt.Stop();
            }
            //else if (e.KeyCode == Keys.ControlKey)
            //{
            //    Form3 frm3 = new Form3();
            //    frm3.Show();
            //}
        }
    }
}