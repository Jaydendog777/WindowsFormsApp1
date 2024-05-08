using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(140, 175, 30, 30);
        Rectangle player2 = new Rectangle(550, 175, 30, 30);
        Rectangle puck = new Rectangle(360, 195, 20, 20);

        Rectangle p1Bottem = new Rectangle(148, 202, 14, 7);
        Rectangle p1Right = new Rectangle(137, 180, 7, 20);
        Rectangle p1Left = new Rectangle(166, 180, 7, 20);
        Rectangle p1Top = new Rectangle(149, 173, 14, 7);

        Rectangle p2Bottem = new Rectangle(557, 202, 14, 7);
        Rectangle p2Right = new Rectangle(548, 180, 7, 20);
        Rectangle p2Left = new Rectangle(576, 180, 7, 20);
        Rectangle p2Top = new Rectangle(557, 173, 14, 7);


        Rectangle center = new Rectangle(360, 0, 10, 500);
        Rectangle goal1 = new Rectangle(0, 160, 13, 60);
        Rectangle goal2 = new Rectangle(735, 160, 13, 60);

        int playerSpeed = 5;
        int puckTotalSpeed = 5;
        int puckSpeed = 5;
        int puckSpeedX = 3;
        int puckSpeedY = 3;
        int puckHit = 0;

        int p1score = 0;
        int p2score = 0;

        bool wPressed = false;
        bool sPressed = false;
        bool upPressed = false;
        bool downPressed = false;

        bool leftPressed = false;
        bool rightPressed = false;
        bool dPressed = false;
        bool aPressed = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush greenBrush = new SolidBrush(Color.LawnGreen);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        Pen border = new Pen(Color.White, 3);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.Left:
                    leftPressed = false;
                    break;
                case Keys.Right:
                    rightPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.Left:
                    leftPressed = true;
                    break;
                case Keys.Right:
                    rightPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            puckHit++;
            if (puckHit == 50)
            {
                if (puckSpeed > 0)
                {
                    puckHit = 0;
                    puckSpeed--;
                }
            }

            if (puck.IntersectsWith(p1Left))
            {
                puckSpeedX = puckTotalSpeed;
                puckStuff();
            }
            if (puck.IntersectsWith(p1Top))
            {
                puckSpeedY = -puckTotalSpeed;
                puckStuff();
            }
            if (puck.IntersectsWith(p1Bottem))
            {
                puckSpeedY = puckTotalSpeed;
                puckStuff();
            }
            if (puck.IntersectsWith(p1Right))
            {
                puckSpeedX = -puckTotalSpeed;
                puckStuff();
            }

            if (puck.IntersectsWith(p2Left))
            {
                puckSpeedX = puckTotalSpeed;
                puckStuff();
            }
            if (puck.IntersectsWith(p2Top))
            {
                puckSpeedY = -puckTotalSpeed;
                puckStuff();
            }
            if (puck.IntersectsWith(p2Bottem))
            {
                puckSpeedY = puckTotalSpeed;
                puckStuff();
            }
            if (puck.IntersectsWith(p2Right))
            {
                puckSpeedX = -puckTotalSpeed;
                puckStuff();
            }



            if (puck.Y >= 320)
            {
                puckSpeedY = -puckSpeed;
            }
            if (puck.Y <= 0)
            {
                puckSpeedY = puckSpeed;
            }

            if (puck.X <= 0)
            {
                puckSpeedX = puckSpeed;
            }
            if (puck.X >= 735)
            {
                puckSpeedX = -puckSpeed;
            }

            if (puckSpeed == 0)
            {
                puckSpeedX = puckSpeedY = 0;
            }

            if (puck.IntersectsWith(goal1))
            {
                if (p2score < 2) 
                {
                    p2score++;
                    p2Points.Text = $"{p2score}";
                    p2Points.Refresh();
                    Thread.Sleep(1000);
                    puck.X = 360;
                    puck.Y = 195;
                }
                else
                {
                    winLabel.Text = "Player 2 wins!";
                    winLabel.Refresh();
                    p2score = 0;
                    p1score = 0;
                    p1Points.Text = $"{p1score}";
                    p2Points.Text = $"{p2score}";
                    p1Points.Refresh();
                    p2Points.Refresh();
                    Thread.Sleep(2000);
                    puck.X = 360;
                    puck.Y = 195;
                }
            }
            if (puck.IntersectsWith(goal2))
            {
                if (p1score < 2)
                {
                    p1score++;
                    p1Points.Text = $"{p1score}";
                    p1Points.Refresh();
                    Thread.Sleep(1000);
                    puck.X = 360;
                    puck.Y = 195;
                }
                else
                {
                    winLabel.Text = "Player 1 wins!";
                    winLabel.Refresh();
                    p2score = 0;
                    p1score = 0;
                    p1Points.Text = $"{p1score}";
                    p2Points.Text = $"{p2score}";
                    p1Points.Refresh();
                    p2Points.Refresh();
                    Thread.Sleep(2000);
                    puck.X = 360;
                    puck.Y = 195;
                }
            }

            puck.X += puckSpeedX;
            puck.Y += puckSpeedY;

            keyCheck();
            Refresh();
        }

        public void puckStuff()
        {
            puckSpeed = puckTotalSpeed;
            puckHit = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(grayBrush, center);
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(greenBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, puck);
            e.Graphics.FillRectangle(grayBrush, goal1);
            e.Graphics.FillRectangle(grayBrush, goal2);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }
        public void keyCheck()
        {
            if (upPressed == true)
            {
                if (player2.Y > 0)
                {
                    player2.Y -= playerSpeed;
                    p2Bottem.Y -= playerSpeed;
                    p2Right.Y -= playerSpeed;
                    p2Top.Y -= playerSpeed;
                    p2Left.Y -= playerSpeed;
                }
            }
            if (downPressed == true)
            {
                if (player2.Y < 330)
                {
                    player2.Y += playerSpeed;
                    p2Bottem.Y += playerSpeed;
                    p2Right.Y += playerSpeed;
                    p2Top.Y += playerSpeed;
                    p2Left.Y += playerSpeed;
                }
            }
            if (leftPressed == true)
            {
                if (player2.X > 370)
                {
                    player2.X -= playerSpeed;
                    p2Bottem.X -= playerSpeed;
                    p2Right.X -= playerSpeed;
                    p2Top.X -= playerSpeed;
                    p2Left.X -= playerSpeed;
                }
            }
            if (rightPressed == true)
            {
                if (player2.X < 710)
                {
                    player2.X += playerSpeed;
                    p2Bottem.X += playerSpeed;
                    p2Right.X += playerSpeed;
                    p2Top.X += playerSpeed;
                    p2Left.X += playerSpeed;
                }
            }

            if (wPressed == true)
            {
                if (player1.Y > 0)
                {
                    player1.Y -= playerSpeed;
                    p1Bottem.Y -= playerSpeed;
                    p1Right.Y -= playerSpeed;
                    p1Top.Y -= playerSpeed;
                    p1Left.Y -= playerSpeed;
                }
            }
            if (sPressed == true)
            {
                if (player1.Y < 330)
                {
                    player1.Y += playerSpeed;
                    p1Bottem.Y += playerSpeed;
                    p1Right.Y += playerSpeed;
                    p1Top.Y += playerSpeed;
                    p1Left.Y += playerSpeed;
                }
            }
            if (aPressed == true)
            {
                if (player1.X > 10)
                {
                    player1.X -= playerSpeed;
                    p1Bottem.X -= playerSpeed;
                    p1Right.X -= playerSpeed;
                    p1Top.X -= playerSpeed;
                    p1Left.X -= playerSpeed;
                }
            }
            if (dPressed == true)
            {
                if (player1.X < 330)
                {
                    player1.X += playerSpeed;
                    p1Bottem.X += playerSpeed;
                    p1Right.X += playerSpeed;
                    p1Top.X += playerSpeed;
                    p1Left.X += playerSpeed;
                }
            }
        }
    }
}
