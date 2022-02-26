using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AppDevTP
{
    class Circle : Dot
    {
        public int radius;

        public Circle(int x, int y, int radius): base(0, 0)
        {
            X = x;
            Y = y;
            this.radius = radius;
        }
        public int rad { get => radius; set => radius = value; }
        
        public new void Draw()
        {
            Pen p = new Pen(Color.Red);
            SolidBrush sb = new SolidBrush(Color.Black);
            g.DrawEllipse(p, X, Y, 50, 50);
            g.FillEllipse(sb, X, Y, radius * 2, radius * 2);
        }
    }
}
