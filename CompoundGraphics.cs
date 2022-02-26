using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevTP
{
    class CompoundGraphics : Graphic
    {
        public ArrayList children = new ArrayList();
        public List<string> childl = new List<string>();
        public Graphics g;

        public void Add(Graphic child)
        {
            this.children.Add(child);
        }

        public void Remove()
        {
            if (children.Count > 0)
            {
                this.children.RemoveAt(this.children.Count - 1);
            }
        }

        public void Move(int x, int y)
        {
            Dot d = new Dot(0, 0);
            d.X = x;
            d.Y = y;
        }

        public void Draw()
        {
            int count = 0;
            //display all the shape in children
            foreach (Dot d in children)
            {
                if (childl[count] == "Circle")
                {
                    Pen p = new Pen(Color.Red);
                    SolidBrush sb = new SolidBrush(Color.Black);
                    g.DrawEllipse(p, d.x, d.y, 30, 30);
                    g.FillEllipse(sb, d.x, d.y, 30, 30);
                }
                count++;
            }
        }
    }
}
