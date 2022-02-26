using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevTP
{
    public partial class ImageEditor : Form
    {
        Dot d, position;
        CompoundGraphics compG = new CompoundGraphics();

        public ImageEditor()
        {
            InitializeComponent();
            d = new Dot(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.Move(d.x - 30, d.y);
            panelDot.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.Move(d.x + 30, d.y);
            panelDot.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d.Move(d.x, d.y - 30);
            panelDot.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d.Move(d.x, d.y + 30);
            panelDot.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Add Shape to Children with incremented x and y
            if (radioButton1.Checked)
            {
                compG.childl.Add("Circle");
            }
            position = new Dot(d.x, d.y);
            compG.Add(position);
            panelDot.Invalidate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //remove one object at a time in children then update panel
            compG.Remove();
            panelDot.Invalidate();
        }

        private void panelDot_Paint(object sender, PaintEventArgs e)
        {
            //draw a shape
            d.g = e.Graphics;
            compG.g = e.Graphics;
            d.Draw();
            compG.Draw();
        }
    }
}
