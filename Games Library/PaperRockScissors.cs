using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLibrary
{
    public class clsPaperRockScissors
    {
        public enum enChoice { Rock = 1 , Paper = 2 , Scissors = 3 };
        public enum enWinner { Player = 1 , Computer =  2 , Draw = 3 };
        static public short Rounds {  get; set; }
        static public string Name { get; set; }
        static public enChoice PcChoice { get; set; }
        static public enChoice PlayerChoice { get; set; }

        static public enWinner WinnerOfRound()
        {
            if (clsPaperRockScissors.PlayerChoice == clsPaperRockScissors.PcChoice)
            {
                return enWinner.Draw;
            }

            switch (clsPaperRockScissors.PlayerChoice)
            {
                case enChoice.Rock:
                    {
                        if (clsPaperRockScissors.PcChoice == enChoice.Paper)
                            return enWinner.Computer;
                        break;
                    }
                case enChoice.Paper:
                    {
                        if (clsPaperRockScissors.PcChoice == enChoice.Scissors)
                            return enWinner.Computer;
                        break;
                    }
                case enChoice.Scissors:
                    {
                        if (clsPaperRockScissors.PcChoice == enChoice.Rock)
                            return enWinner.Computer;
                        break;
                    }
            }

            return enWinner.Player;
        }

        static public enWinner WinnerOfGame(short Wins , short Loses)
        {
            if (Loses > Wins)
                return enWinner.Computer;

            if (Wins >  Loses)
                return enWinner.Player;

            return enWinner.Draw;
        }

    }
}
