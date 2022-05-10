using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snek
{
    // TODO: 
    // pause when minimize window
    // check change direcion (witch func works)
    // make save, load, snap btns
    // make unpause
    // disable mouse events if !gaming
    // add instructions
    // try to disable switching btns with arrows
    // try to make CheckWalls accurate
    // 
    public class Snake
    {
        public List<BodyPart> snake { get; set; }// = new List<BodyPart>();
        public Direction Dir { get; set; }
        

        public Snake()
        {
            snake = new List<BodyPart>();
            Dir = Direction.Left;
        }

        ~Snake() { }

        public void grow()
        {
            BodyPart head = snake[snake.Count - 1];
            snake.Add(head);
        }

        internal void Move()
        {
            BodyPart tail = snake.First();
            snake.Remove(tail);
            BodyPart head = GetNextPoint();
            snake.Add(head);
            head.move(Dir);
            tail.Dispose();
        }

        public BodyPart GetNextPoint()
        {
            BodyPart head = snake.Last();
            BodyPart nextPoint = new BodyPart(head.X, head.Y, head.radius);
            nextPoint.move(Dir);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = snake.Last();
            for (int i = 0; i < snake.Count - 1; i++)
            {
                if (head.IsOn(snake[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void CheckWalls()
        {
            if (snake[snake.Count - 1].X > 450)
            {
                snake[snake.Count - 1].X = 0;
            }
            else if (snake[snake.Count - 1].Y > 400)
            {
                snake[snake.Count - 1].Y = 0;
            }
            else if (snake[snake.Count - 1].X < 0)
            {
                snake[snake.Count - 1].X = 450;
            }
            else if (snake[snake.Count - 1].Y < 0)
            {
                snake[snake.Count - 1].Y = 400;
            }
        }

    }
}
