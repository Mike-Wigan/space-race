using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace space_race
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        Stopwatch afterstart = new Stopwatch();

        Rectangle astorides = new Rectangle(0, 0, 2, 10);
        Rectangle player1 = new Rectangle(200, 420, 15, 30);
        Rectangle player2 = new Rectangle(650, 420, 15, 30);

        Random randgen = new Random();
        int randvalue;
        int pspeed = 5;
        int playerheight = 30;
        int p1score = 0;
        int p2score = 0;
        string assstart;
        double clock = 30;
        string start;

        bool rdown = false;
        bool wdown = false;
        bool sdown = false;
        bool updown = false;
        bool downdown = false;
        bool escdown = false;
        bool spacedown = false;

        Pen whitepen = new Pen(Color.White, 5);
        SolidBrush redbrush = new SolidBrush(Color.Red);
        SolidBrush bluebrush = new SolidBrush(Color.Blue);
        SolidBrush whitebrush = new SolidBrush(Color.White);

        List<int> astoridespeedlist = new List<int>();
        List<Rectangle> astorideslist = new List<Rectangle>();


        public Form1()
        {
            InitializeComponent();w
            start = "dontstart";
            outputlabel.Visible = true;
            p1scorelabel.Visible = false;
            p2scorelabel.Visible = false;
            countdownlabel.Visible = false;
            outputlabel.Text = "Press space to start and esc to close the program";
        }


        public void gamestart()
        {
            start = "start";
            Gametimer.Enabled = true;
            outputlabel.Visible = false;
            countdownlabel.Visible = true;
            countdownlabel.Text = "3";
            stopwatch.Restart();
            p1scorelabel
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    escdown = true;
                    break;
                case Keys.Space:
                    gamestart();
                    spacedown = true;
                    break;
                case Keys.W:
                    wdown = true;
                    break;
                case Keys.S:
                    sdown = true;
                    break;
                case Keys.Up:
                    updown = true;
                    break;
                case Keys.Down:
                    downdown = true;
                    break;
                case Keys.R:
                    rdown = true;
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    escdown = false;
                    break;
                case Keys.Space:
                    spacedown = false;
                    break;
                case Keys.W:
                    wdown = false;
                    break;
                case Keys.S:
                    sdown = false;
                    break;
                case Keys.Up:
                    updown = false;
                    break;
                case Keys.Down:
                    downdown = false;
                    break;
                case Keys.R:
                    rdown = false;
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (start == "start")
            {
                //player 1
                e.Graphics.FillEllipse(bluebrush, player1);
                //e.Graphics.FillRectangle(redbrush, 210, player1.Y + 25, 5, 15);
                e.Graphics.FillEllipse(whitebrush, 201, player1.Y + 3, 13, 10);


                //player 2
                e.Graphics.FillEllipse(redbrush, player2);
                //e.Graphics.FillRectangle(redbrush, 651, player2.Y + 25, 5, 17);
                //e.Graphics.FillRectangle(redbrush, 660, player2.Y + 25, 5, 17);         
                e.Graphics.FillEllipse(whitebrush, 651, player2.Y + 3, 13, 10);

                //astorides
                for (int i = 1; i < astorideslist.Count; i++)
                {
                    e.Graphics.FillRectangle(whitebrush, astorideslist[i]);
                }
            }
        }
        private void Gametimer_Tick(object sender, EventArgs e)
        {
            if (clock != 0)
            {
                if (stopwatch.ElapsedMilliseconds >= 1500)
                {
                    countdownlabel.Text = "2";
                }
                if (stopwatch.ElapsedMilliseconds >= 3000)
                {
                    countdownlabel.Text = "1";
                }
                if (stopwatch.ElapsedMilliseconds >= 4500)
                {
                    countdownlabel.Text = "GO";
                }
                timerlabel.Text = $"{clock}";
                //creat an astoride
                randvalue = randgen.Next(1, 100);
                if (randvalue > 70)
                {

                    if (randvalue > 85)
                    {
                        randvalue = randgen.Next(0, 360);
                        assstart = "left";
                        Rectangle astorides = new Rectangle(0, randvalue, 15, 5);
                        astorideslist.Add(astorides);
                        astoridespeedlist.Add(randgen.Next(2, 5));
                    }
                    else
                    {
                        randvalue = randgen.Next(0, 380);
                        assstart = "right";
                        Rectangle astorides = new Rectangle(this.Width, randvalue, 15, 5);
                        astorideslist.Add(astorides);
                        astoridespeedlist.Add(randgen.Next(-5, -2));
                    }
                }
                for (int i = 1; i < astorideslist.Count; i++)
                {
                    int x = astorideslist[i].X + astoridespeedlist[i];
                    int y = astorideslist[i].Y;
                    astorideslist[i] = new Rectangle(x, y, 10, 3);
                }
                //remove astorides
                for (int i = 1; i < astorideslist.Count; i++)
                {
                    if (astorideslist[i].X >= 900 || astorideslist[i].X <= 0)
                    {
                        astorideslist.RemoveAt(i);
                        astoridespeedlist.RemoveAt(i);
                    }
                }
                //can move players after 6 seconds
                if (stopwatch.ElapsedMilliseconds >= 6000)
                {
                    pspeed = 5;
                    countdownlabel.Visible = false;
                    afterstart.Start();
                    //collisions
                    for (int i = 0; i < astorideslist.Count; i++)
                    {
                        if (astorideslist[i].IntersectsWith(player1))
                        {
                            player1.Y = 420;
                        }
                        if (player2.IntersectsWith(astorideslist[i]))
                        {
                            player2.Y = 420;
                        }
                    }
                    //move player 1
                    if (wdown == true)
                    {
                        player1.Y -= pspeed;
                    }

                    if (sdown == true && player1.Y < 420)
                    {
                        player1.Y += pspeed;
                    }
                    //move player 2
                    if (updown == true)
                    {
                        player2.Y -= pspeed;
                    }
                    if (downdown == true && player2.Y < 420)
                    {
                        player2.Y += pspeed;
                    }
                    //scoreing
                    if (player1.Y <= 0)
                    {
                        p1score++;
                        p1scorelabel.Text = $"{p1score}";
                        player1.Y = 390;
                    }
                    if (player2.Y <= 0)
                    {
                        p2score++;
                        p2scorelabel.Text = $"{p2score}";
                        player2.Y = 390;
                    }
                    clock--;
                }
            }
            else
            {
                pspeed = 0;
                outputlabel.Visible = true;
                for (int i = 1; i > astoridespeedlist.Count; i++)
                {
                    astoridespeedlist[i] = 0;
                }
                if (p1score > p2score)
                {
                    outputlabel.Text = "Blue wins";
                }
                if (p2score < p1score)
                {
                    outputlabel.Text = "Red wins";
                }
                else if (p1score == p2score)
                {
                    outputlabel.Text = "Tie";
                }
            }
            //other consol contorls
            if (escdown == true)
            {
                this.Close();
            }
            if (rdown == true)
            {
                astoridespeedlist.Clear();
                astorideslist.Clear();
                pspeed = 5;
                stopwatch.Restart();
            }
            Refresh();
        }
    }
}

