using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevTP
{
    class Dot : Graphic
    {
        public int x;
        public int y;
        public Graphics g;

        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);
            g.DrawEllipse(p, x, y, 30, 30);
            g.FillEllipse(sb, x + 10, y + 10, 10, 10);
        }
    }
}
