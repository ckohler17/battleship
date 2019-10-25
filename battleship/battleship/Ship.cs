using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    abstract class Ship
    {
        //member variables(Has A)
        public int length;
        public string name;


        //constructor(Builds)
        public Ship()
        {
            
        }

        //member methods(Can Do)
        public abstract void DetermineIfShipSunk();

    }
}
