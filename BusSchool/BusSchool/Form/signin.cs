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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(162, 0, 26);
            label1.BackColor = Color.Transparent;
            Play.BackColor = Color.FromArgb(179, 25, 32);
            SignUp.BackColor = Color.FromArgb(179, 25, 32);
            Back.BackColor = Color.FromArgb(179, 25, 32);
            foreach (Player X in Game.playerList)
            {
                comboBox1.Items.Add(X.Name);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                for(int i=0;i<Game.playerList.Count();i++)
                {
                    Player X = Game.playerList[i];
                    if (comboBox1.SelectedItem == X.Name)
                    {
                        Game.idx = i;
                        Game.cur_Duration = 0;
                        Game.cur_Score = 0;
                        new level1().Show();
                        this.Hide();
                    }
                }


            }

            else
            {
                MessageBox.Show("You Should Selected Profile or Sign up ");
                comboBox1.SelectedItem = null;
                comboBox1.Focus();
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
