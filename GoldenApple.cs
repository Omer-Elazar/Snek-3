using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek
{
    public class GoldenApple : Food // spawns randomly, gives more points, has decay
    {
        public bool exist { get; set; } // interval = 50 => 200 ticks = 10 seconds

        public int Points { get; set; }

        public SolidBrush br { get; set; }

        public GoldenApple()
        {
            exist = false;
            Points = 5;
            br = new SolidBrush(Color.Yellow);
            Color = Color.Yellow;
            //Circle golden = new Circle(random.Next(0, 9), random.Next(0, 9));
        }

        ~GoldenApple() { }

        public override void Eat()
        {
            score += Points;
            Scoretxt.Text = "Score: " + score;
            this.Dispose();
            exist = false;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(this.Color);
            Pen pen = new Pen(Color.Cyan, 2);
            g.FillEllipse(br, X - radius, Y - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(pen, X - radius, Y - radius, 2 * radius, 2 * radius);
        }
    }
}
