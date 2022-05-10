using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snek
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        //List<BodyPart> body = new List<BodyPart>();
        //BodyPart part = new BodyPart();
        //body.Add(part);

        Snake snake;
        AppleList Apples;
        GoldenApple golden;
        Random rand;

        public int score = 0;
        public int highscore = 0;

        public bool gaming = false;
        public bool goLeft, goRight, goDown, goUp;
        int MouseIndex = -1;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            GoldenTimer.Start();
            Startbtn.Enabled = false;
            timer1.Enabled = true;
            GoldenTimer.Enabled = true;
            Pausebtn.Enabled = true;
            Snapbtn.Enabled = false;
            Loadbtn.Enabled = false;
            Savebtn.Enabled = false;

            snake = new Snake();
            int i;
            for (i = 0; i < 4; i++)
            {
                snake.snake.Add(new BodyPart());
                snake.snake[snake.snake.Count - 1].X -= 5;
            }
            Apples = new AppleList();
            golden = new GoldenApple();
            rand = new Random();

            score = 0;
            Scoretxt.Text = "Score: " + score;
            HighScoretxt.Text = "HighScore: " + highscore;
            HighScoretxt.BackColor = Color.White;
            gaming = true;
            Pausebtn.Text = "Pause";
            pictureBox1.Invalidate();

        }

        private void Pausebtn_Click(object sender, EventArgs e)
        {
            if (Pausebtn.Text == "UnPause")
            {
                Pausebtn.Text = "Pause";
                timer1.Start();
                GoldenTimer.Start();
                Startbtn.Enabled = false;
                timer1.Enabled = true;
                GoldenTimer.Enabled = true;
                Pausebtn.Enabled = true;
                Snapbtn.Enabled = false;
                Loadbtn.Enabled = false;
                Savebtn.Enabled = false;
            }
            else
            {
                timer1.Stop();
                GoldenTimer.Stop();
                Pausebtn.Text = "UnPause";
                Startbtn.Enabled = true;
                Savebtn.Enabled = true;
                Snapbtn.Enabled = true;
                timer1.Enabled = false;
                GoldenTimer.Enabled = false;
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }

        private void Snapbtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!gaming)
            {
                return;
            }
            Graphics g = e.Graphics;
            int i;
            for (i = 0; i < snake.snake.Count; i++)
            {
                snake.snake[i].Draw(g);
            }
            for (i = 0; i < Apples.Apples.Count; i++)
            {
                Apples[i].Draw(g);
            }
            if (golden.exist)
            {
                golden.Draw(g);
            }
        }

        private void GoldenTimerTick(object sender, EventArgs e)
        {
            if (golden.exist)
            {
                golden.exist = false;
                golden.Dispose();
            }
            if (rand.Next(0, 2) == 1)
            {
                golden = new GoldenApple();
                bool isnoton = false;
                int x, y;
                while (!isnoton)
                {
                    golden.X = rand.Next(5, 400);
                    golden.X = golden.X - (golden.X % 10) + 5;
                    golden.Y = rand.Next(5, 350);
                    golden.Y = golden.Y - (golden.Y % 10) + 5;
                    int i;
                    for (i = 0; i < snake.snake.Count; i++)
                    {
                        if (snake.snake[i].IsOn(golden))
                        {
                            golden.X = rand.Next(5, 400);
                            golden.X = golden.X - (golden.X % 10) + 5;
                            golden.Y = rand.Next(5, 350);
                            golden.Y = golden.Y - (golden.Y % 10) + 5;
                            break;
                        }
                    }
                    isnoton = true;
                }
                golden.exist = true;
            }
            pictureBox1.Invalidate();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Scoretxt.BackColor = Color.White;
            snake.CheckWalls();
            if (goLeft)
            {
                snake.Dir = Direction.Left;
            }
            if (goRight)
            {
                snake.Dir = Direction.Right;
            }
            if (goDown)
            {
                snake.Dir = Direction.Down;
            }
            if (goUp)
            {
                snake.Dir = Direction.Up;
            }
            snake.Move();
            snake.CheckWalls();
            if (snake.IsHitTail())
            {
                GameOver();
            }
            if (golden.exist && snake.GetNextPoint().IsOn(golden))//is on golden apple
            {
                score += 5;
                golden.Eat();
                Scoretxt.BackColor = Color.Gold;
            }
            else
            {
                int i;
                for (i = 0; i < Apples.Apples.Count; i++)
                {
                    if (snake.snake[snake.snake.Count - 1].IsOn(Apples[i]))//is on apple
                    {
                        snake.grow();
                        Apples[i].Eat();
                        score++;
                        Apples.Apples.RemoveAt(i);
                        if (Apples.Apples.Count == 0)
                        {
                            Apples[0] = new Apple();
                            bool isnoton = false;
                            int x, y;
                            while (!isnoton)
                            {
                                Apples[0].X = rand.Next(5, 400);
                                Apples[0].X = Apples[0].X - (Apples[0].X % 10) + 5;
                                Apples[0].Y = rand.Next(5, 350);
                                Apples[0].Y = Apples[0].Y - (Apples[0].Y % 10) + 5;
                                for (i = 0; i < snake.snake.Count; i++)
                                {
                                    if (snake.snake[i].IsOn(Apples[0]))
                                    {
                                        Apples[0].X = rand.Next(5, 400);
                                        Apples[0].X = Apples[0].X - (Apples[0].X % 10) + 5;
                                        Apples[0].Y = rand.Next(5, 350);
                                        Apples[0].Y = Apples[0].Y - (Apples[0].Y % 10) + 5;
                                        break;
                                    }
                                }
                                isnoton = true;
                            }
                        }
                    }
                }
            }
            if (golden.exist)
            {
                //golden.br. -= 20;
            }
            Scoretxt.Text = "Score: " + score;
            pictureBox1.Invalidate();
        } 

        private void ArrowKeyPress(object sender, KeyEventArgs e)
        {

            // snake.changeDir(e);
            if (e.KeyCode == Keys.A && snake.Dir != Direction.Right)
            {
                snake.Dir = Direction.Left;
            }
            if (e.KeyCode == Keys.D && snake.Dir != Direction.Left)
            {
                snake.Dir = Direction.Right;
            }
            if (e.KeyCode == Keys.W && snake.Dir != Direction.Down)
            {
                snake.Dir = Direction.Up;
            }
            if (e.KeyCode == Keys.S && snake.Dir != Direction.Up)
            {
                snake.Dir = Direction.Down;
            }
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //int i;
            //if (e.Button == MouseButtons.Left)
            //{
            //    for (i = 0;  i < snake.snake.Count; i++)
            //    {//add check for golden apple
            //        if (e.X == snake.snake[i].X && e.Y == snake.snake[i].Y)
            //        {
            //            return;
            //        }
            //    }
            //    for (i = 0; i < Apples.Apples.Count; i++)
            //    {
            //        if (e.X == Apples[i].X && e.Y == Apples[i].Y)
            //        {
            //            return;
            //        }
            //    }
            //    Apples[Apples.Apples.Count] = new Apple(e.X, e.Y);
            //}
            //else if (e.Button == MouseButtons.Right)
            //{
            //    if (Apples.Apples.Count > 2)
            //    {
            //        for (i = 0; i < Apples.Apples.Count; i++)
            //        {
            //            if (e.X - (e.X % 10) + 5 == Apples[i].X && e.Y - (e.Y % 10) + 5 == Apples[i].Y)
            //            {
            //                Apples.Apples.RemoveAt(i);
            //            }
            //        }
            //    }
            //}
            //pictureBox1.Invalidate();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' && Startbtn.Enabled == false)
            {
                Pausebtn_Click(sender, e);
            }
            else if (e.KeyChar == ' ' && Startbtn.Enabled == true)
            {
                Pausebtn_Click(sender, e);
            }
            else if (e.KeyChar == (char)Keys.A && snake.Dir != Direction.Right)
            {
                snake.Dir = Direction.Left;
            }
            else if (e.KeyChar == (char)Keys.D && snake.Dir != Direction.Left)
            {
                snake.Dir = Direction.Right;
            }
            else if (e.KeyChar == (char)Keys.W && snake.Dir != Direction.Down)
            {
                snake.Dir = Direction.Up;
            }
            else if (e.KeyChar == (char)Keys.S && snake.Dir != Direction.Up)
            {
                snake.Dir = Direction.Down;
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            GoldenTimer.Stop();
            Pausebtn.Enabled = false;
            Startbtn.Enabled = true;
            Savebtn.Enabled = true;
            Snapbtn.Enabled = true;
            timer1.Enabled = false;
            GoldenTimer.Enabled = false;
            if (score > highscore)
            {
                highscore = score;
                HighScoretxt.Text = "New!! HighScore: " + highscore.ToString();
                HighScoretxt.BackColor = Color.Yellow;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gaming)
            {
                return;
            }
            MouseIndex = -1;
            int i;
            for (i = 0; i < Apples.Apples.Count; i++)
            {
                if (e.X > Apples[i].X - 5 && e.X < Apples[i].X + 5 && e.Y > Apples[i].Y - 5 && e.Y < Apples[i].Y + 5)
                {
                    MouseIndex = i;
                    if (e.Button == MouseButtons.Right)
                    {
                        Apples.Apples.RemoveAt(i);
                        MouseIndex = -1;
                        pictureBox1.Invalidate();
                        return;
                    }
                }
            }
            if (MouseIndex < 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    bool ison  =false;
                    for (i = 0; i < snake.snake.Count; i++)
                    {//add check for golden apple
                        if (e.X > snake.snake[i].X - 6 && e.X < snake.snake[i].X + 6 && e.Y > snake.snake[i].Y - 6 && e.Y < snake.snake[i].Y + 6)
                        {
                            ison = true;
                        }
                    }
                    for (i = 0; i < Apples.Apples.Count; i++)
                    {
                        if (e.X > Apples[i].X - 6 && e.X < Apples[i].X + 6 && e.Y > Apples[i].Y - 6 && e.Y < Apples[i].Y + 6)
                        {
                            ison = true;
                        }
                    }
                    if (!ison)
                    {
                        Apples[Apples.Apples.Count] = new Apple(e.X, e.Y);
                    }
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIndex >= 0)
            {
                int i;
                bool ison = false;
                for (i = 0; i < snake.snake.Count; i++)
                {//add check for golden apple
                    if (e.X > snake.snake[i].X - 6 && e.X < snake.snake[i].X + 6 && e.Y > snake.snake[i].Y - 6 && e.Y < snake.snake[i].Y + 6)
                    {
                        ison = true;
                    }
                }
                for (i = 0; i < Apples.Apples.Count; i++)
                {
                    if (e.X > Apples[i].X - 6 && e.X < Apples[i].X + 6 && e.Y > Apples[i].Y - 6 && e.Y < Apples[i].Y + 6)
                    {
                        ison = true;
                    }
                }
                if (!ison)
                {
                    Apples[MouseIndex].X = e.X - (e.X % 10) + 5;
                    Apples[MouseIndex].Y = e.Y - (e.Y % 10) + 5;
                }
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIndex = -1;
            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Space && Startbtn.Enabled == false)
            //{
            //    Pausebtn_Click(sender, e);
            //}
            //else if (e.KeyCode == Keys.Space && Startbtn.Enabled == true)
            //{
            //    Startbtn_Click(sender, e);
            //}
            //else if (e.KeyCode == Keys.A && snake.Dir != Direction.Right)
            //{
            //    snake.Dir = Direction.Left;
            //}
            //else if (e.KeyCode == Keys.D && snake.Dir != Direction.Left)
            //{
            //    snake.Dir = Direction.Right;
            //}
            //else if (e.KeyCode == Keys.W && snake.Dir != Direction.Down)
            //{
            //    snake.Dir = Direction.Up;
            //}
            //else if (e.KeyCode == Keys.S && snake.Dir != Direction.Up)
            //{
            //    snake.Dir = Direction.Down;
            //}

            if (e.KeyCode == Keys.A && snake.Dir != Direction.Right)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D && snake.Dir != Direction.Left)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.W && snake.Dir != Direction.Down)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.S && snake.Dir != Direction.Up)
            {
                goDown = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up && snake.Dir != Direction.Down)
            {
                snake.Dir = Direction.Up;
            }
            //capture down arrow key
            if (keyData == Keys.Down && snake.Dir != Direction.Up)
            {
                snake.Dir = Direction.Down;
            }
            //capture left arrow key
            if (keyData == Keys.Left && snake.Dir != Direction.Right)
            {
                snake.Dir = Direction.Left;
            }
            //capture right arrow key
            if (keyData == Keys.Right && snake.Dir != Direction.Left)
            {
                snake.Dir = Direction.Right;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
