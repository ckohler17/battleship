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
            //List<char> letters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T' };
            //char[,] board = new char[21, 21];
            //for (int i = 0; i < 21; i++)
            //{
            //    for (int j = 0; j < 21; j++)
            //    {
            //        char letter = 'O';
            //        if (i == 0 && j > 0)
            //        {
            //            letter = letters[j - 1];
            //        }
            //        if (i > 0 && j == 0)
            //        {
            //            ;
            //        }
            //        board[i, j] = letter;
            //        board[0, 0] = '\0';
            //        board[1, 0] = '1';
            //        Console.Write(board[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            List<string> letters = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" };
            string[,] board = new string[21, 22];
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    string letter = "O";
                    if (i == 0 && j > 0)
                    {
                        letter = letters[j - 1];
                        
                    }
                    if (i > 0 && i < 10 && j == 0)
                    {
                       letter = i.ToString() + " "; 
                    }
                    if(i > 9 && i < 22 && j == 0)
                    {
                        letter = i.ToString();
                    }
                         
                    board[i, j] = letter;
                    board[0, 0] = "\0";
                    board[1, 0] = "1";
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
