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
using BusSchool.Properties;

namespace BusSchool
{
    public partial class history : Form
    {
        
       
        
        public history()
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            InitializeComponent();
           
          foreach(History r in Game.H)
            {
                dataGridView1.Rows.Add(r.profile_name, r.date.ToShortDateString(), r.duration+"S", r.score, r.level);
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form11_Click(object sender, EventArgs e)
        {
           
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            
                if (dataGridView2.Visible == true)
                {
                    dataGridView2.Rows.Clear();
                    dataGridView2.Visible = false;
                }
                else
                {
                    int counter = 1;
                    foreach(Steps s in Game.H[row].StepsList1)
                    {
                        string side="";
                        if (s.Right)
                        {
                            side = "Right";
                        }
                        if (s.Left)
                        {
                            side = "Left";
                        }
                        if (s.Up)
                        {
                            side = "Up";
                        }
                        if (s.Down)
                        {
                            side = "Down";
                        }
                   
                        dataGridView2.Rows.Add(counter, side,s.time2-s.time+" ms");
                        counter++;
                   
                       
                    
                    }
                dataGridView2.Visible = true;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
        public void ChangeStyle()
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 220, 204);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 98, 26); ;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 98, 26); ;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bradley Hand ITC", 14, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Bradley Hand ITC", 10, FontStyle.Bold ^ FontStyle.Italic);
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(255, 98, 26);
          
        }
     
        public void ChangeStyle2()
        {
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 220, 204);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 98, 26); ;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 98, 26); ;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Bradley Hand ITC", 14, FontStyle.Bold);
            dataGridView2.DefaultCellStyle.Font = new Font("Bradley Hand ITC", 10, FontStyle.Bold ^ FontStyle.Italic);
            dataGridView2.DefaultCellStyle.ForeColor = Color.FromArgb(255, 98, 26);
           
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            ChangeStyle();
            button1.BackColor = Color.FromArgb(255, 98, 26);
            button1.ForeColor = Color.White;
            ChangeStyle2();
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 85;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 75;
            dataGridView2.Columns[0].Width = 60;
            dataGridView2.Columns[1].Width = 75;
            dataGridView2.Columns[2].Width = 85;
        }
    }
}
