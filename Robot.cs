using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB8_Robot
{
    class Robot
    {
        int x, y, a,
            crvena, plava, zelena;
        SolidBrush cetka = new SolidBrush(Color.FromArgb(210, 105, 30));
        Random rand = new Random();
        Pen olovka = new Pen(Color.Black, 4);
        
        public Robot(int x,int  y, int a)
        {
            this.x = x;
            this.y = y;
            this.a = a;
        }

        public void Crtaj(Graphics g)
        {
            
            g.DrawLine(olovka, x, y - a / 4, x, y - 3 * a / 8);
            g.FillPie(new SolidBrush(Color.White), x - a / 4, y - a / 4, a / 2, a / 2, 0, -180);
            g.DrawArc(olovka, x - a / 4, y - a / 4, a / 2, a / 2, 0, -180);
            g.DrawLine(olovka, x - a / 4, y, x + a / 4, y);
            g.FillEllipse(new SolidBrush(Color.Black), x - a / 16, y - 3 * a / 16, a / 8, a / 8);
            g.FillEllipse(new SolidBrush(Color.White), x - a / 2, y, a, a);
            g.DrawEllipse(olovka, x - a / 2, y, a, a);
            g.FillEllipse(cetka, x - a / 4, y + a / 4, a / 2, a / 2);
            g.DrawEllipse(olovka, x - a / 4, y + a / 4, a / 2, a / 2);
        }

        public void Pomeri(int dx, int dy, bool menjajBoje)
        {
            x += dx;
            y += dy;

            if (menjajBoje)
            {
                crvena = rand.Next(256);
                plava = rand.Next(256);
                zelena = rand.Next(256);
                cetka.Color = Color.FromArgb(crvena, plava, zelena);
            }
        }


    }
}
