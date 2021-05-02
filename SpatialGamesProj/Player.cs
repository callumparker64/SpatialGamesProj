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

        public void Adjacency(string adjStrat)
        {
            if(strategy == "C")
            {
                if (adjStrat == "C")
                {
                    Score = Score + 1;
                }
                else if (adjStrat == "D")
                {
                    Score = Score - 3;
                }
                else if(adjStrat == "T")
                {

                }
            }
            else if (strategy == "D")
            {
                if (adjStrat == "C")
                {
                    Score = Score + 3;
                }
                else if (adjStrat == "D")
                {
                    Score = Score - 1;
                }
                else if (adjStrat == "T")
                {

                }
            }
            else if (strategy == "T")
            {
                if (adjStrat == "C")
                {
                    Score = Score + 1;
                }
                else if (adjStrat == "D")
                {
                    Score = Score - 3;
                }
                else if (adjStrat == "T")
                {

                }
            }


        }



    }
}
