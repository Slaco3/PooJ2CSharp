using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooJ2CSharp
{
    class Griffin : Animal
    {
        public Griffin()
        {
            this.Name = "Griffin";
        }
        public Griffin(string Name)
        {
            this.Name = Name;
        }
        public override void Moove()
        {
            Console.WriteLine("Je suis un Griffon qui bouge");
        }

        public override void Sleep()
        {
            Console.Write("Je suis un Griffon qui dort");
        }
    }
}
