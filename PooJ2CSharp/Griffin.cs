using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PooJ2CSharp
{
    class Griffin : Animal
    {
        public Griffin()
        {
            this.Name = "Griffin";

        }
        public Griffin(string name, Rarety rarety, int id)
        {
            this.Id = id;
            this.Name = name;
            this.Rarety = rarety;
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
