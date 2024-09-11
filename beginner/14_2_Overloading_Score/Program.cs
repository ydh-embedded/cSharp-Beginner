using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_Overloading_Score;

class Program
{
    static void Main(string[] args)
    {
                           Console.WriteLine(@"

            **************************************************************************

                    Score Overloading

                    All arithmetic and comparison operators can be overloaded.
                    For instance, you could define greater than and
                    less than operators for the boxes that would
                    compare the Boxes and return a boolean result.
                    Just keep in mind that when overloading the greater than
                    operator, the less than operator should also be defined.

            **************************************************************************");
            //REVIEW -   (player_1 , player_2)
            Score iR1 = new Score(1, 5);
            Score iR2 = new Score(1, 5);
            Score iR3 = new Score(1, 5);
            Score iR4 = new Score(1, 5);

            Score finalScores = iR1 + iR2 + iR3 + iR4;


            Console.WriteLine("Round 1: " + finalScores.iRound1Score + " Points Player 1");
            Console.WriteLine("Round 2: " + finalScores.iRound2Score + " Points Player 2");

    }
}

    class Score                                                           //ANCHOR - class Score
    {
        public int iRound1Score { get; set; }
        public int iRound2Score { get; set; }
        public Score(int r1, int r2)
        {
            iRound1Score = r1;
            iRound2Score = r2;
        }
        
        //your code goes here
        public static Score operator +(Score player_1, Score player_2)      //ANCHOR - +Overloading Score
        {
            if (player_1 == null)
            {
                throw new ArgumentNullException(nameof(player_1), "Player 1 score cannot be null");
            }
        
            if (player_2 == null)
            {
                throw new ArgumentNullException(nameof(player_2), "Player 2 score cannot be null");
            }
        
            // return new Score(player_1.iRound1Score + player_2.iRound1Score , player_1.iRound2Score + player_2.iRound2Score);
            
            int iRound_1 = player_1.iRound1Score + player_2.iRound1Score;
            int iRound_2 = player_1.iRound2Score + player_2.iRound2Score;

            Score result = new Score(iRound_1, iRound_2);
            return result;
        }
        
    }
