using System;
using System.Collections.Generic;
using System.Text;

namespace SpatialGamesProj
{
    class Player
    {
        public string strategy { get; set; }
        public int xCoor { get; set; }
        public int yCoor { get; set; }
        public int Score { get; set; }

        public Player(string strategy,int x, int y, int score)
        {
            this.strategy = strategy;
            xCoor = x;
            yCoor = y;
            Score = score;
        }

        public void Adjacency(List<Player> players)
        {
            if(strategy.Equals("C"))
            {
                for (int i = xCoor - 1; i < xCoor + 1; i++)
                {
                    for (int j = yCoor - 1; j < yCoor + 1; j++)
                    {
                        if(i >= 0 & j >= 0)
                        {
                            if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("C"))
                            {
                                Score = Score + 1;
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("D"))
                            {
                                Score = Score - 3;
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("T"))
                            {
                                Score = Score + 1;
                            }
                        }

                    }

                }
            }
            else if(strategy.Equals("D"))
            {
                for (int i = xCoor - 1; i < xCoor + 1; i++)
                {
                    for (int j = yCoor - 1; j < yCoor + 1; j++)
                    {
                        if (i >= 0 & j >= 0)
                        {
                            if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("C"))
                            {
                                Score = Score + 1;
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("D"))
                            {
                                Score = Score - 3;
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("T"))
                            {
                                Score = Score + 1;
                            }
                        }
                    }

                }
            }
            else if(strategy == "T")
            {
                for (int i = xCoor - 1; i < xCoor + 1; i++)
                {
                    for (int j = yCoor - 1; j < yCoor + 1; j++)
                    {
                        if (i >= 0 & j >= 0)
                        {
                            if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("C"))
                            {
                                Score = Score + 1;
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("D"))
                            {
                                Score = Score - 3;
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("T"))
                            {
                                Score = Score + 1;
                            }
                        }
                    }

                }
            }

        }

    }
}
