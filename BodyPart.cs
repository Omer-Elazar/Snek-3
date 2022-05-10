using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek
{
    public class BodyPart : Circle
    {
        public BodyPart()
        {
            X = pictureBox1.Width / 2 - (pictureBox1.Width / 2 % 10) + 5;
            Y = pictureBox1.Height / 2 - (pictureBox1.Height / 2 % 10) + 5;
            Color = Color.Green;
        }

        public BodyPart(int x, int y, int rad)
        {
            X = x;
            Y = y;
            radius = rad;
            Color = Color.Green;
        }

        public void move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    X -= 5;
                    break;
                case Direction.Right:
                    X += 5;
                    break;
                case Direction.Up:
                    Y -= 5;
                    break;
                case Direction.Down:
                    Y += 5;
                    break;
            }
        }

        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(this.Color);
            Pen pen = new Pen(Color.Cyan, 2);
            g.FillEllipse(br, X - radius, Y - radius, 2 * radius, 2 * radius);
            //g.DrawEllipse(pen, X - radius, Y - radius, 2 * radius, 2 * radius);
        }



    }
}
