using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Player
    {
        //member variables(Has A)
        public int score;
        public string name;
        public List<string> ships;
        

        //constructor(Builds)
        public Player()
        {
            Player player = new Player();
            ships = new List<string>() {"destroyer", "submarine", "battleship", "aircraft carrier"};
        }
        
        //member methods(Can Do)
        public void PositionShip()
        {

        }
        public void ChooseName()
        {

        }
        
    }
}
