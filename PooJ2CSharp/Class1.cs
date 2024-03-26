using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooJ2CSharp
{
    class Animal
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

        public void Moove()
        {
            Console.WriteLine("Moove");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }



    }
}
