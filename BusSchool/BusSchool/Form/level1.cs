﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusSchool.Classes;

namespace BusSchool
{

    public partial class level1 : Form
    {
        public level1()
        {
            InitializeComponent();
        }
        Stopwatch stopwatch ;
        bool MoveRight, MoveLeft, MoveUp, MoveDown;
        int Side = 1;//left=1,right=2,up=3,down=4;
        int Dir = 0;
        int speed = 15;
        private void Form9_Load(object sender, EventArgs e)
        {
            Program.playBacks.Clear();
            ScoreLabel.Text = "Score : " + Game.cur_Score;
            LevelLabel.Text = "Level : 1";
            Game.cur_time = 0;
            Game.NOG++;
            Game.cur_Duration=0;
            Game.cur_Score = 0;
            stopwatch = Stopwatch.StartNew();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            int Theme = Game.playerList[Game.idx].Theme;
            if (Theme == 1)
            {
                this.BackgroundImage = Properties.Resources.x1;
                pictureBox1.Image = Properties.Resources.x1;
            }
            else if (Theme == 2)
            {
                this.BackgroundImage = Properties.Resources.y1;
                pictureBox1.Image = Properties.Resources.y1;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.z1;
                pictureBox1.Image = Properties.Resources.z1;
            }
            foreach (Control x in Controls)
            {

                if ((string)x.Tag == "Buttom")
                {
                    x.BackColor = Color.Transparent;
                }
                if ((string)x.Tag == "Top")
                {
                    x.BackColor = Color.Transparent;
                }
                if ((string)x.Tag == "Right")
                {
                    x.BackColor = Color.Transparent;
                }
                if ((string)x.Tag == "Left")
                {
                    x.BackColor = Color.Transparent;
                }
            }
            Bus.BackColor = Color.Transparent;
            School.BackColor = Color.Transparent;
           

            int[] xsBus = { 920, 920, 920, 920 };
            int[] ysBus = { 15, 217, 316, 455 };
            Random randBus = new Random();
            int idxBus = randBus.Next(4);
            Bus.Left = xsBus[idxBus];
            Bus.Top = ysBus[idxBus];

            int[] xsSchool = { -3, -3, -3, 279 };
            int[] ysSchool = { 106, 298, 480, 515 };
            Random randSchool = new Random();
            int idxSchool = randSchool.Next(4);
            School.Left = xsSchool[idxSchool];
            School.Top = ysSchool[idxSchool];
        }
       
        private void RotateUp(PictureBox Bus)
        {

            if (Side == 1)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                Bus.Image = Flip;
            }
            if (Side == 2)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                Bus.Image = Flip;
            }
            if (Side == 4)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Width, Bus.Height);
                Flip.RotateFlip(RotateFlipType.Rotate180FlipNone);
                Bus.Image = Flip;
            }
        }
        private void RotateDown(PictureBox Bus)
        {
            if (Side == 1)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                Bus.Image = Flip;
            }
            if (Side == 2)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                Bus.Image = Flip;
            }
            if (Side == 3)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Width, Bus.Height);
                Flip.RotateFlip(RotateFlipType.Rotate180FlipNone);
                Bus.Image = Flip;
            }
        }
        private void RotateLeft(PictureBox Bus)
        {
            if (Side == 2)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Width, Bus.Height);
                Flip.RotateFlip(RotateFlipType.Rotate180FlipXY);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipX);
                Bus.Image = Flip;
            }
            if (Side == 3)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                Bus.Image = Flip;
            }
            if (Side == 4)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                Bus.Image = Flip;
            }
        }
        private void RotateRight(PictureBox Bus)
        {
            if (Side == 1)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Width, Bus.Height);
                Flip.RotateFlip(RotateFlipType.Rotate180FlipNone);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Bus.Image = Flip;
            }
            if (Side == 3)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipY);

                Bus.Image = Flip;
            }
            if (Side == 4)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Bus.Image = Flip;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            Dir = 0;
            if (e.KeyCode == Keys.Left)
            {
                Steps s = new Steps(false, true, false, false, Game.cur_time, stopwatch.ElapsedMilliseconds);
                Game.cur_time = 0;
                Game.StepsList.Add(s);
                Game.StepsList[Game.StepsList.Count() - 1].time2 = stopwatch.ElapsedMilliseconds;
                MoveLeft = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                Steps s = new Steps(true, false, false, false, Game.cur_time, stopwatch.ElapsedMilliseconds);
                Game.cur_time = 0;
                Game.StepsList.Add(s);
                Game.StepsList[Game.StepsList.Count() - 1].time2 = stopwatch.ElapsedMilliseconds;
                MoveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                Steps s = new Steps(false, false, true, false,Game.cur_time, stopwatch.ElapsedMilliseconds);
                Game.cur_time = 0;
                Game.StepsList.Add(s);
                Game.StepsList[Game.StepsList.Count() - 1].time2 = stopwatch.ElapsedMilliseconds;
                MoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                Steps s = new Steps(false, false, false, true,Game.cur_time, stopwatch.ElapsedMilliseconds);
                Game.cur_time = 0;
                Game.StepsList.Add(s);
                Game.StepsList[Game.StepsList.Count() - 1].time2 = stopwatch.ElapsedMilliseconds;
                MoveDown = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MoveRight == true)
            {
                Bus.Left += speed;
            }
            if (MoveLeft == true)
            {
                Bus.Left -= speed;
            }
            if (MoveUp == true)
            {
                Bus.Top -= speed;
            }
            if (MoveDown == true)
            {
                Bus.Top += speed;
            }
            foreach (Control x in Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Buttom")
                    {
                        if (x.Bounds.IntersectsWith(Bus.Bounds))
                        {
                            Bus.Top = x.Top + x.Height;
                        }
                    }
                    if ((string)x.Tag == "Top")
                    {
                        if (x.Bounds.IntersectsWith(Bus.Bounds))
                        {
                            Bus.Top = x.Top - Bus.Height;
                        }
                    }
                    if ((string)x.Tag == "Right")
                    {
                        if (x.Bounds.IntersectsWith(Bus.Bounds))
                        {
                            Bus.Left = x.Left + x.Width;
                        }
                    }
                    if ((string)x.Tag == "Left")
                    {
                        if (x.Bounds.IntersectsWith(Bus.Bounds))
                        {
                            Bus.Left = x.Left - Bus.Width;
                        }
                    }
                }
            }

            playBack p = new playBack();
            p.X = Bus.Left;
            p.Y = Bus.Top;
            p.side = Side;
            p.SchoolX = School.Left;
            p.SchoolY = School.Top;
            
            Program.playBacks.Add(p);

            foreach (Control x in this.Controls)
            {

                if ((string)x.Tag == "School")
                {
                    if (x.Bounds.IntersectsWith(Bus.Bounds))
                    {
                        
                        timer1.Stop();
                        Game.level = 1;
                        stopwatch.Stop();
                        Game.cur_Duration += (stopwatch.ElapsedMilliseconds) / 1000;
                       
                        Game.cur_Score = 15;
                        string name = Game.playerList[Game.idx].Name;
                        DateTime d = DateTime.Now;
                        long duration = Game.cur_Duration;
                        long score = Game.cur_Score;
                        History hi = new History(name, d, duration, score, Game.level);
                        Game.H.Add(hi);
                        foreach (Steps s in Game.StepsList)
                        {
                            Game.H[Game.H.Count() - 1].StepsList1.Add(s);
                        }
                        Game.StepsList.Clear();
                        betweenlevels f = new betweenlevels();
                        this.Hide();
                        f.ShowDialog();
                        this.Close();


                    }
                }

            }
        }

        
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                RotateLeft(Bus);
                Side = 1;
                MoveLeft = true;
                Dir = 1;
                if (Game.cur_time == 0)
                {
                    Game.cur_time = stopwatch.ElapsedMilliseconds;
                }
                
                
            }
            if (e.KeyCode == Keys.Right)
            {
                RotateRight(Bus);
                Side = 2;
                MoveRight = true;
                Dir = 2;
                if (Game.cur_time == 0)
                {
                    Game.cur_time = stopwatch.ElapsedMilliseconds;
                }

            }
            if (e.KeyCode == Keys.Up)
            {
                RotateUp(Bus);
                Side = 3;
                MoveUp = true;
                Dir = 3;
                if (Game.cur_time == 0)
                {
                    Game.cur_time = stopwatch.ElapsedMilliseconds;
                }

            }
            if (e.KeyCode == Keys.Down)
            {
                RotateDown(Bus);
                Side = 4;
                MoveDown = true;
                Dir = 4;
                if (Game.cur_time == 0)
                {
                    Game.cur_time = stopwatch.ElapsedMilliseconds;
                }

            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_COMPOSITED = 0x02000000;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }

    }
}
