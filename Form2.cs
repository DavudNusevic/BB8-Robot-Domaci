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
    public partial class Form2 : Form
    {
        Random rand = new Random();
        Robot[] roboti = new Robot[8];
        int a = 100,
            x, y,
            px, py,
            dx, dy;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = PointToClient(MousePosition).X;
            y = PointToClient(MousePosition).Y;

            dx = x - px;
            dy = y - py;

            for (int i = 0; i < roboti.Length; i++)
                if (dx != 0 || dy != 0)
                    roboti[i].Pomeri(dx, dy, true);
           
            px = x;
            py = y;
            if (dx != 0 || dy != 0)
                Refresh();
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            foreach (Robot r in roboti)
                r.Crtaj(e.Graphics);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            px = PointToClient(MousePosition).X;
            py = PointToClient(MousePosition).Y;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < roboti.Length; i++)
                roboti[i] = new Robot(rand.Next(a/ 2 + 5, ClientRectangle.Width - a/2 - 5), 
                                      rand.Next(a, ClientRectangle.Height - a - 5), a);
            
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
