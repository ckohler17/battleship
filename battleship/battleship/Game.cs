using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Game
    {

        //member variables(Has A)
        
        Player player1;
        Player player2;

        //constructor(Builds)
        public Game()
        {
            char[,] board = new char[20, 20];            
                for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    board[i, j] = 'O';
                    Console.Write(board[i, j]);
                 }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

 

        //member methods(Can Do)
        public void RunGame()
        {

        }
        public void DisplayRules()
        {

        }
        public void TakingTurns()
        {

        }
        public void DetermineWinner()
        {

        }
        public void DisplayWinner()
        {

        }
    }
}
