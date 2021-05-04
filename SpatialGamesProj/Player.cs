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
        public List<int> scores = new List<int>();

        public Player(string playerStrat, int x, int y, int score)
        {
            strategy = playerStrat;
            xCoor = x;
            yCoor = y;
            Score = score;
        }

        public void Adjacency(List<Player> players, int gridSize)
        {
            if (strategy.Equals("C"))
            {
                for (int i = xCoor - 1; i <= xCoor + 1; i++)
                {
                    for (int j = yCoor - 1; j <= yCoor + 1; j++)
                    {
                        if (i >= 0 & j >= 0 & i < gridSize & j < gridSize & !(i == xCoor & j == yCoor))
                        {
                            if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("C"))
                            {
                                Score = Score + 2;
                                scores.Add(Score);
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("D"))
                            {
                                Score = Score - 4;
                                scores.Add(Score);
                                if (Score < -10)
                                {
                                    strategy = players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy;
                                }
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("T"))
                            {
                                Score = Score + 2;
                                scores.Add(Score);
                            }
                        }

                    }

                }
            }
            else if (strategy.Equals("D"))
            {
                for (int i = xCoor - 1; i <= xCoor + 1; i++)
                {
                    for (int j = yCoor - 1; j <= yCoor + 1; j++)
                    {
                        if (i >= 0 & j >= 0 & i < gridSize & j < gridSize & !(i == xCoor & j == yCoor))
                        {
                            if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("C"))
                            {
                                Score = Score + 4;
                                scores.Add(Score);
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("D"))
                            {
                                Score = Score - 1;
                                scores.Add(Score);
                                if (Score < -10)
                                {
                                    strategy = "C";
                                }
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("T") & players.Find(Player => Player.xCoor == i & Player.yCoor == j).Score < 3)
                            {
                                Score = Score - 1;
                                scores.Add(Score);
                                if (Score < -10)
                                {
                                    strategy = players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy;
                                }
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("T"))
                            {
                                Score = Score + 4;
                                scores.Add(Score);
                            }
                        }

                    }
                }
            }
            else if (strategy == "T")
            {
                for (int i = xCoor - 1; i <= xCoor + 1; i++)
                {
                    for (int j = yCoor - 1; j <= yCoor + 1; j++)
                    {
                        if (i >= 0 & j >= 0 & i < gridSize & j < gridSize & !(i == xCoor & j == yCoor))
                        {
                            if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("C"))
                            {
                                Score = Score + 2;
                                scores.Add(Score);
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("D") & Score < 3)
                            {
                                Score = Score - 1;
                                scores.Add(Score);
                                if (Score < -10)
                                {
                                    strategy = players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy;
                                }
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("D"))
                            {
                                Score = Score - 4;
                                scores.Add(Score);
                                if (Score < -10)
                                {
                                    strategy = players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy;
                                }
                            }
                            else if (players.Find(Player => Player.xCoor == i & Player.yCoor == j).strategy.Equals("T"))
                            {
                                Score = Score + 2;
                                scores.Add(Score);
                            }
                        }
                    }

                }
            }

            }

        }
    }
