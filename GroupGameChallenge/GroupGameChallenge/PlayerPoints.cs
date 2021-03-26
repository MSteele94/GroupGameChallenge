using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGameChallenge
{
    public class PlayerPoints
    {
        public int PlayerScore { get; set; } = 0;
        public int PlayerScoreCinema { get; set; } = 0;




        public PlayerPoints(){}

        public PlayerPoints(int playerScore, int playerScoreCinema)
        {
            PlayerScore = playerScore;
            PlayerScoreCinema = playerScoreCinema;
        }
    }
}
