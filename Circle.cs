using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snek
{
    [Serializable]
    public class Circle : Form1// all renderables
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int radius { get; set; }

        public static int width { get; }

        public static int height { get; }

        public virtual Color Color { get; set; }


        public Circle() { X = 32; Y = 32; radius = 5; Color = Color.Honeydew; }

        public Circle(int x, int y) { X = x; Y = y; }

        ~Circle() { }

        public bool IsOn(Circle c)
        {
            return c.X > X - 10 && c.X < X + 10 && c.Y > Y - 10 && c.Y < Y + 10;
        }

        public virtual void Draw(Graphics g) { }

    }
}
