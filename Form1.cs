using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BB8_Robot
{
    public partial class Form1 : Form
    {
        int a = 100, v = 7;
        Robot robot;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            button1.Width = ClientRectangle.Width / 10;
            button1.Top = (int)(ClientRectangle.Height * 0.9);
            button1.Left = (int)(ClientRectangle.Width * 0.85);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            robot = new Robot(ClientRectangle.Width / 2, ClientRectangle.Height / 2 - 3 * a / 8, a);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            robot.Crtaj(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 app2 = new Form2();
            app2.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            robot.Pomeri(v, 0, false);
            Refresh();
        }
    }
}
