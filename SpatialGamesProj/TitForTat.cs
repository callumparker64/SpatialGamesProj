namespace SpatialGames
{
    public class TitForTat
    {
        public int xCoor {get; set;}
        public int yCoor{get; set;}
        public int Score {get; set;}

        public TitForTat(int x,int y,int score)
        {
            xCoor = x;
            yCoor = y;
            Score = score;
        }

        // public void Adjacency()
        // {

        //      for (int i = 0; i < xCoor + 2; i++)
        //     {
        //         for (int j = 0; j <  yCoor + 2; j++)
        //         {
        //             if(i == xCoor && j == yCoor)
        //             {
        //                 break;
        //             }
        //             else if(//adj is Split)
        //             {
        //                 Score = Score + 1;
        //             }
        //             else if(//adj is Steal)
        //             {
        //                 Score = Score - 1;
        //             }
        //             else if(//adj is TitForTat)
        //             {
        //                 //
        //             }
                    
        //         }
        //     }
        // }


    }
}