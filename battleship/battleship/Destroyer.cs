using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Destroyer : Ship
    {
        //member variables(Has A)

        //constructor(Builds)
        public Destroyer()
        {
            length = 2;
            name = "Destroyer";
        }

        //member methods(Can Do)
        public override void DetermineIfShipSunk()
        {

        }
    }
}
