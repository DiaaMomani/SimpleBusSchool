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

    public partial class Form2 : Form
    {
          public Form2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Transparent;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            new Form4().Show();
            this.Hide();
        }

       

        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Game.playerList.Count() == 0)
            {
                MessageBox.Show("Please sign up first");
            }
            else
            {
                new statistics().Show();
                this.Hide();
            }
        }

        private void hosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Game.playerList.Count() == 0)
            {
                MessageBox.Show("Please sign up first");
            }
            else
            {
                new history().Show();
                this.Hide();
            }
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bonus b = new Bonus();
            b.Show();
        }
    }
}
