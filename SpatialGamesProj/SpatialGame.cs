﻿using SpatialGames;
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
        public int gameLen { get; }
        public int gridSize { get; }
        public int coopNo { get; set; }
        public int defNo { get; set; }
        public int titfortatNo { get; set; }
        public String stratArrange { get; }
        int rounds = 0;
        List<String> playerStrategies = new List<String>();
        List<Player> playerList = new List<Player>();

        public SpatialGame(int gameLen,int gridSize,int coopNo,int defNo,int titfortatNo,String stratArrange)
        {
           
            InitializeComponent();

            lblTest2.Text = gameLen.ToString();
            lblGrid.Text = gridSize.ToString();
            lblCoop.Text = coopNo.ToString();
            lblDefect.Text = defNo.ToString();
            lblTitForTat.Text = titfortatNo.ToString();
            lblArrange.Text = stratArrange;

            this.gameLen = gameLen;
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
            else if (stratArrange.Equals("RBlock"))
            {
                for (int i = (coopNo + defNo + titfortatNo) - 1; i >= 0; i--)
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
                int sumC = 0;
                int sumD = 0;
                int sumT = 0;
                for (int i = 0; (sumC + sumD + sumT) < (coopNo + defNo + titfortatNo); i++)
                {
                    Random rnd = new Random();
                    int rndInt = rnd.Next(3);

                    if (rndInt == 0 & sumC < coopNo)
                    {
                        sumC = sumC + 1;
                        playerStrategies.Add("C");

                    }
                    else if (rndInt == 1 & sumD < defNo)
                    {
                        sumD = sumD + 1;
                        playerStrategies.Add("D");

                    }
                    else if (rndInt == 2 & sumT < titfortatNo)
                    {
                        sumT = sumT + 1;
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
                    Label l = addPlayer(num,xPos,yPos, playerStrategies[num],i,j);
                    this.Controls.Add(l);
                    num = num + 1;
                    yPos = yPos + 40;
                }
                yPos = 40;
                xPos = xPos + 100;
            }



        }

        Label addPlayer(int i, int x, int y, String playerStrategy, int xPos, int yPos)
        {
            //PlayerStrategy is used to is a case/if to decide which class to call when generating a player object
            if (playerStrategy.Equals("C"))
            {
                playerList.Add(new Player("C", xPos, yPos, 0));
                Label l = new Label();
                l.Name = "lblCoop" + i.ToString();
                l.Text = "Coop" + i.ToString();
                l.Margin = new Padding(3);
                l.Location = new Point(x, y);
                return l;
            }
            else if (playerStrategy.Equals("D"))
            {
                playerList.Add(new Player("D", xPos, yPos, 0));
                Label l = new Label();
                l.Name = "lblDefect" + i.ToString();
                l.Text = "Defect" + i.ToString();
                l.Margin = new Padding(3);
                l.Location = new Point(x, y);
                return l;
            }
            else if (playerStrategy.Equals("T"))
            {
                playerList.Add(new Player("T", xPos, yPos, 0));
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
            Graphs g1 = new Graphs(rounds,playerList);
            g1.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object Sender, EventArgs e)
        {

            // Game is stopped after reaching round limit
            if(rounds == gameLen)
            {
                timer1.Enabled = false;
            }
            else
            {
                rounds = rounds + 1;
                lblRounds.Text = "Round: " + (rounds).ToString();
            }

            playerList.ForEach(Player => Player.Adjacency(playerList, gridSize));
            lbltestScore.Text = playerList.Find(Player => Player.xCoor == 0 & Player.yCoor == 0).Score.ToString();
            lbltestScore2.Text = playerList.Find(Player => Player.xCoor == 1 & Player.yCoor == 1).Score.ToString();
            lbltestScore3.Text = playerList.Find(Player => Player.xCoor == 2 & Player.yCoor == 2).Score.ToString();
            int checkNum = 0;
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (playerList.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("C"))
                    {
                        //Testing method to check if the players do change strategy based on situation
                        if (this.Controls.ContainsKey("lblDefect"+i))
                        {
                            lblTest.Text = "Defect > Coop";
                        }
                    }
                    else if (playerList.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("D"))
                    {
                        if (this.Controls.ContainsKey("lblCoop" + i))
                        {
                            lblTest.Text = "Coop > Defect";
                        }
                        if (this.Controls.ContainsKey("lblTitforTat" + i))
                        {
                            lblTest.Text = "TitforTat > Defect";
                        }
                    }
                    else if (playerList.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("T"))
                    {
                        if (this.Controls.ContainsKey("lblCoop" + i))
                        {
                            lblTest.Text = "Coop > Defect";
                        }
                    }
                    checkNum = checkNum + 1;
                }
            }

        }

        private void btnTwoX_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 333;
        }

        private void lbltestScore2_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            playerList.ForEach(Player => Player.Adjacency(playerList,gridSize));
            lbltestScore.Text = playerList.Find(Player => Player.xCoor == 0 & Player.yCoor == 0).Score.ToString();
            lbltestScore2.Text = playerList.Find(Player => Player.xCoor == 1 & Player.yCoor == 1).Score.ToString();
            lbltestScore3.Text = playerList.Find(Player => Player.xCoor == 2 & Player.yCoor == 2).Score.ToString();

        }
    }
}
