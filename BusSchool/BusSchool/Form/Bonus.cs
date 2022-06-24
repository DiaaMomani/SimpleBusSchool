using BusSchool.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusSchool
{
    public partial class Bonus : Form
    {
        int idx = 0;
        public Bonus()
        {
            InitializeComponent();
        }
        bool MoveRight, MoveLeft, MoveUp, MoveDown;
        int Side = 1;//left=1,right=2,up=3,down=4;
        int Dir = 0;
        int speed = 15;
        private void Bonus_Load(object sender, EventArgs e)
        {

            int Theme = Game.playerList[Game.idx].Theme;
            if (Theme == 1)
            {
                this.BackgroundImage = Properties.Resources.x1;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.Image = Properties.Resources.x1;
            }
            else if (Theme == 2)
            {
                this.BackgroundImage = Properties.Resources.y1;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.Image = Properties.Resources.y1;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.z1;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.Image = Properties.Resources.z1;
            }
            Bus.BackColor = Color.Transparent;
            School.BackColor = Color.Transparent;
            Rock1.BackColor = Color.Transparent;
            Rock2.BackColor = Color.Transparent;
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
            Side = 3;
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
            Side = 4;
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
            Side = 1;
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
            Side = 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            School.Left = Program.playBacks[idx].SchoolX;
            School.Top = Program.playBacks[idx].SchoolY;
            Rock1.Left = Program.playBacks[idx].Rock1X;
            Rock1.Top = Program.playBacks[idx].Rock1Y;
            Rock2.Left = Program.playBacks[idx].Rock2X;
            Rock2.Top = Program.playBacks[idx].Rock2Y;
            RecordProgress(idx);
            idx++;
            if (idx == Program.playBacks.Count)
            {
                timer1.Enabled = false;
            }

        }

        public void RecordProgress(int idx)
        {
            if(Program.playBacks[idx].side== 1)
            {
                RotateLeft(Bus);
            }
            if (Program.playBacks[idx].side == 2)
            {
                RotateRight(Bus);
            }
            if (Program.playBacks[idx].side == 3)
            {
                RotateUp(Bus);
            }
            if (Program.playBacks[idx].side == 4)
            {
                RotateDown(Bus);
            }
            Bus.Location = new Point(Program.playBacks[idx].X, Program.playBacks[idx].Y);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
