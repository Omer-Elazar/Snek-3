using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek
{
    public class Apple : Food // classic snake apple
    {

        int points = 1;

        public Apple()
        {
            X = random.Next(100, 200);
            Y = random.Next(100, 200);
            X = X - (X % 10) + 5;
            Y = Y - (Y % 10) + 5;
            Color = Color.Red;
        }

        public Apple(int x, int y)
        {
            X = x - (x % 10) + 5;
            Y = y - (y % 10) + 5;
            Color = Color.Red;
        }

        ~Apple() { }

        public override void Eat()
        {
            Scoretxt.Text = "Score: " + score;
            this.Dispose();
        }

        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(Color);
            Pen pen = new Pen(Color.Cyan, 2);
            g.FillEllipse(br, X - radius, Y - radius, 2 * radius, 2 * radius);
            //g.DrawEllipse(pen, X - radius, Y - radius, 2 * radius, 2 * radius);
        }
    }
}
