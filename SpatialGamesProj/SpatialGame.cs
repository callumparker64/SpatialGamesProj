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
        public int gridSize { get; set; }
        public int coopNo { get; set; }
        public int defNo { get; set; }
        public int titfortatNo { get; set; }
        public String stratArrange { get; }
        int rounds = 0;
        List<String> playerStrategies = new List<String>();

        public SpatialGame(string testStr,int gridSize,int coopNo,int defNo,int titfortatNo,String stratArrange)
        {
           
            InitializeComponent();

            lblTest2.Text = testStr;
            lblGrid.Text = gridSize.ToString();
            lblCoop.Text = coopNo.ToString();
            lblDefect.Text = defNo.ToString();
            lblTitForTat.Text = titfortatNo.ToString();
            lblArrange.Text = stratArrange;

            this.gridSize = gridSize;
            this.coopNo = coopNo;
            this.defNo = defNo;
            this.titfortatNo = titfortatNo;
            this.stratArrange = stratArrange;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int xPos = 40;
            int yPos = 40;


            int num = 0;


            //Selection to generate strategy array with different settings
            if (stratArrange.Equals("Scatter"))
            {
                for (int i = 0; i < (coopNo + defNo + titfortatNo); i++)
                {
                    if (i < coopNo)
                    {
                        playerStrategies.Add("C");
                    }
                    else if (i - coopNo < defNo)
                    {
                        playerStrategies.Add("D");
                    }
                    else if (i - (coopNo + defNo) < titfortatNo)
                    {
                        playerStrategies.Add("T");
                    }

                }
            }
            else if (stratArrange.Equals("Block"))
            {
                for (int i = 0; i < (coopNo + defNo + titfortatNo); i++)
                {
                    if(i < coopNo)
                    {
                         playerStrategies.Add("C");
                    }
                    else if(i - coopNo < defNo)
                    {
                         playerStrategies.Add("D");
                    }
                    else if(i - (coopNo + defNo) < titfortatNo)
                    {
                         playerStrategies.Add("T");
                    }

                }

            }
            else if (stratArrange.Equals("Rows"))
            {
                for (int i = 0; i < (coopNo + defNo + titfortatNo); i++)
                {
                    if (i < coopNo)
                    {
                        playerStrategies.Add("C");
                    }
                    else if (i - coopNo < defNo)
                    {
                        playerStrategies.Add("D");
                    }
                    else if (i - (coopNo + defNo) < titfortatNo)
                    {
                        playerStrategies.Add("T");
                    }

                }
            }
            else if (stratArrange.Equals("Random"))
            {
                for (int i = 0; i < (coopNo + defNo + titfortatNo); i++)
                {
                    if (i < coopNo)
                    {
                        playerStrategies.Add("C");
                    }
                    else if (i - coopNo < defNo)
                    {
                        playerStrategies.Add("D");
                    }
                    else if (i - (coopNo + defNo) < titfortatNo)
                    {
                        playerStrategies.Add("T");
                    }

                }
            }


            string combindedString = string.Join(",", playerStrategies.ToArray());
            MessageBox.Show(combindedString, "Test");

            for (int i = 0;i<gridSize;i++)
            {
                for(int j = 0;j<gridSize;j++)
                {
                    Label l = addPlayer(num,xPos,yPos, playerStrategies[num]);
                    this.Controls.Add(l);
                    num = num + 1;
                    yPos = yPos + 40;
                }
                yPos = 40;
                xPos = xPos + 100;
            }

            //for (int i = 0; i < 9; i++)
            //{
             //   for (int j = 0; j < 9; j++)
              //  {
              //      Label l = addPlayer(num);
             //       flowLayoutPanel1.Controls.Add(l);
             //       num = num + 1;
             //   }
            //
            //}



        }

        Label addPlayer(int i, int x, int y, String playerStrategy)
        {
            //PlayerStrategy is used to is a case/if to decide which class to call when generating a player object
            if (playerStrategy.Equals("C"))
            {
                Label l = new Label();
                l.Name = "lblCoop" + i.ToString();
                l.Text = "Coop" + i.ToString();
                l.Margin = new Padding(3);
                l.Location = new Point(x, y);
                return l;
            }
            else if (playerStrategy.Equals("D"))
            {
                Label l = new Label();
                l.Name = "lblDefect" + i.ToString();
                l.Text = "Defect" + i.ToString();
                l.Margin = new Padding(3);
                l.Location = new Point(x, y);
                return l;
            }
            else if (playerStrategy.Equals("T"))
            {
                Label l = new Label();
                l.Name = "lblTitforTat" + i.ToString();
                l.Text = "TitforTat" + i.ToString();
                l.Margin = new Padding(3);
                l.Location = new Point(x, y);
                return l;
            }
            else
            {
                Label l = new Label();
                l.Name = "lblPlayer" + i.ToString();
                l.Text = "Player" + i.ToString();
                l.Margin = new Padding(3);
                l.Location = new Point(x, y);
                return l;
            }

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

        private void btnStart_Click(object sender, EventArgs e)
        {
            rounds = rounds + 1;
            lblRounds.Text = "Round: " +(rounds).ToString();
        }
    }
}
