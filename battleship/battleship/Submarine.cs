using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Submarine : Ship
    {
        //member variables(Has A)

        //constructor(Builds)
        public Submarine()
        {
            length = 3;
            name = "Submarine";
        }

        //member methods(Can Do)
        public override void DetermineIfShipSunk()
        {

        }
    }
}
