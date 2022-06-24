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
    public partial class betweenlevels : Form
    {
        public betweenlevels()
        {
            InitializeComponent();
            textBox1.Text = Game.H[Game.H.Count() - 1].score.ToString()
            +Environment.NewLine+"Time: "+ Game.H[Game.H.Count() - 1].duration.ToString()+"s";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
            
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (Game.level == 1)
            {
                

                Game.playerList[Game.idx].Highest_Score = Math.Max(Game.playerList[Game.idx].Highest_Score, 15);
                Game.playerList[Game.idx].Highest_Dur = Math.Max(Game.playerList[Game.idx].Highest_Dur, Game.cur_Duration);
                Game.playerList[Game.idx].Lowest_Dur = Math.Min(Game.playerList[Game.idx].Lowest_Dur, Game.cur_Duration);
                Game.playerList[Game.idx].Highest_Score = Math.Max(Game.playerList[Game.idx].Highest_Score, Game.cur_Score);
                Game.playerList[Game.idx].Total_Dur += Game.cur_Duration;
                if (Game.playerList[Game.idx].Lowest_Score == 0)
                    Game.playerList[Game.idx].Lowest_Score = Game.cur_Score;
                else
                    Game.playerList[Game.idx].Lowest_Score = Math.Min(Game.playerList[Game.idx].Lowest_Score, Game.cur_Score);

                if (Game.playerList[Game.idx].Lowest_Dur == 0)

                    Game.playerList[Game.idx].Lowest_Dur = Game.cur_Duration;
                else
                    Game.playerList[Game.idx].Lowest_Dur = Math.Min(Game.playerList[Game.idx].Lowest_Dur, Game.cur_Duration);
                foreach (Steps s in Game.StepsList)
                {
                    Game.H[Game.H.Count() - 1].StepsList1.Add(s);
                }
                Game.StepsList.Clear();

            }
            if (Game.level == 2)
            {
                Game.playerList[Game.idx].Highest_Dur = Math.Max(Game.playerList[Game.idx].Highest_Dur, Game.cur_Duration);
                Game.playerList[Game.idx].Lowest_Dur = Math.Min(Game.playerList[Game.idx].Lowest_Dur, Game.cur_Duration);
                Game.playerList[Game.idx].Highest_Score = Math.Max(Game.playerList[Game.idx].Highest_Score, Game.cur_Score);
                Game.playerList[Game.idx].Total_Dur += Game.cur_Duration;
                if (Game.playerList[Game.idx].Lowest_Score == 0)
                    Game.playerList[Game.idx].Lowest_Score = Game.cur_Score;
                else
                    Game.playerList[Game.idx].Lowest_Score = Math.Min(Game.playerList[Game.idx].Lowest_Score, Game.cur_Score);

                if (Game.playerList[Game.idx].Lowest_Dur == 0)

                    Game.playerList[Game.idx].Lowest_Dur = Game.cur_Duration;
                else
                    Game.playerList[Game.idx].Lowest_Dur = Math.Min(Game.playerList[Game.idx].Lowest_Dur, Game.cur_Duration);
                foreach (Steps s in Game.StepsList)
                {
                    Game.H[Game.H.Count() - 1].StepsList1.Add(s);
                }
                Game.StepsList.Clear();
            }
                Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 98, 26);
            button1.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(255, 98, 26);
            button2.ForeColor = Color.White;
            textBox1.ForeColor= Color.FromArgb(255, 98, 26);
            label1.ForeColor= Color.FromArgb(255, 98, 26);
            label1.BackColor = Color.Transparent;
           
            textBox1.Text ="Score: "+Environment.NewLine+ Game.H[Game.H.Count() - 1].score.ToString()
            + Environment.NewLine + "Time: " + Game.H[Game.H.Count() - 1].duration.ToString()+"s";
        }

        private void button1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (Game.level == 1)
            {
                level2 f = new level2();
                this.Hide();
                f.ShowDialog();
                this.Close();

            }
            if (Game.level == 2)
            {
                level3 f = new level3();
                this.Hide();
                f.ShowDialog();
                this.Close();

            }
            if (Game.level == 3)
            {
                button1.Enabled = false;

            }

        }
    }
}
