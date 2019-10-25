using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    class Aircraft_Carrier : Ship
    {
        //member variables(Has A)

        //constructor(Builds)
        public Aircraft_Carrier()
        {
            length = 5;
            name = "Aircraft Carrier";
        }

        //member methods(Can Do)
        public override void DetermineIfShipSunk()
        {

        }
    }
}
