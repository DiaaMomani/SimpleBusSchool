using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusSchool.Classes;

namespace BusSchool
{
    public partial class Form3 : Form
    {
        int Theme=0;
        
        public Form3()
        {
            InitializeComponent();
            for (int i = 7; i <= 50; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            UserNameLabel.BackColor = Color.Transparent;
            AgeLabel.BackColor = Color.Transparent;
            Back.BackColor = Color.FromArgb(179, 25, 32);
            Save.BackColor = Color.FromArgb(179, 25, 32);
            groupBox1.BackColor = Color.Transparent;
            Boy.BackColor = Color.Transparent;
            Girl.BackColor = Color.Transparent;
            Gender.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            UserNameLabel.ForeColor = Color.FromArgb(162,0, 26);
            AgeLabel.ForeColor = Color.FromArgb(162, 0, 26);
            Gender.ForeColor = Color.FromArgb(162, 0, 26);
            label1.ForeColor = Color.FromArgb(162, 0, 26);
            Girl.ForeColor = Color.FromArgb(162, 0, 26);
            Boy.ForeColor = Color.FromArgb(162, 0, 26);
            buttonImage.BackColor = Color.FromArgb(179, 25, 32);
        }
        string gender = "";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Boy";
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Girl_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Girl";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string name = UserNameTextBox.Text;
            string age = comboBox1.Text;
            if (UserNameTextBox.Text == null || comboBox1.SelectedItem == null || gender=="" || UserPhoto.Image==null ||Theme==0)
            {
                MessageBox.Show("Please Fill in All Fields");
            }
            else
            {
                Player p = new Player(name, gender, age, UserPhoto.Image.ToString(),Theme);
                Game.playerList.Add(p);
                new Form2().Show();
                this.Hide();
            }
            
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Theme = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Theme = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Theme = 3;
        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "GIF|*.gif|PNG|*.png|JPEG|*.jpeg";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                UserPhoto.Image = new Bitmap(opnfd.FileName);
            }
            UserPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
