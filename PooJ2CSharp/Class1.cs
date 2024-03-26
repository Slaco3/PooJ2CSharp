using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooJ2CSharp
{
    abstract class Animal
    {
        public string Name;


        public Animal()
        {
            this.Name = "Animal";
        }
        public Animal(string Name)
        {
            this.Name = Name;
        }

        public abstract void Moove();

        public abstract void Sleep();

    }

    class Dragon : Animal
    {
        public override void Moove()
        {
            Console.WriteLine("Je suis un dragon qui bouge");
        }

        public new void Sleep()
        {
            Console.Write("Je suis un dragon qui dort");
        }
    }

    class Griffin : Animal
    {
        public override void Moove()
        {
            Console.WriteLine("Je suis un Griffon qui bouge");
        }

        public new void Sleep()
        {
            Console.Write("Je suis un Griffon qui dort");
        }
    }
}
