using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpatialGamesProj
{
    public partial class SpatialGame : Form
    {

        public SpatialGame(string testStr,int noPlayers,int coopNo,int defNo,int titfortatNo,String stratArrange)
        {
           
            InitializeComponent();

            lblTest2.Text = testStr;
            lblGrid.Text = noPlayers.ToString();
            lblCoop.Text = coopNo.ToString();
            lblDefect.Text = defNo.ToString();
            lblTitForTat.Text = titfortatNo.ToString();
            lblArrange.Text = stratArrange;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            int num = 0;
            for(int i = 0;i<9;i++)
            {
                for(int j = 0;j<9;j++)
                {
                    Label l = addLabel(num);
                    flowLayoutPanel1.Controls.Add(l);
                    num = num + 1;
                }
 
            }

        }

        Label addLabel(int i )
        {
            Label l = new Label();
            l.Name = "lbl"+i.ToString();
            l.Text = "Player"+i.ToString();
            l.Margin = new Padding(3);
            return l;

        }
            

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Graphs g1 = new Graphs();
            g1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
