using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooJ2CSharp
{
    class Vehicle : IPilotage
    {
        public Vehicle() { }

        public void Moove()
        {
            Console.WriteLine("Le véhicule avance");
        }
    }
}
