using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Battleship : Ship
    {
        //member variables(Has A)

        //constructor(Builds)
        public Battleship()
        {
            length = 4;
            name = "Battleship";
        }

        //member methods(Can Do)
        public override void DetermineIfShipSunk()
        {

        }
    }
}
