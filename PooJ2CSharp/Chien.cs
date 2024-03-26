using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PooJ2CSharp
{
    class Dog : Animal
    {
        public Dog()
        {
            this.Name = "CHIEN-CHIEN";
        }
        public Dog(string name, string rarety, int id)
        {
            this.Id = id;   
            this.Name = name;
            this.Rarety = rarety;
        }
        public override void Moove()
        {
            Console.WriteLine("Le chien avance");
        }

        public override void Sleep()
        {
            Console.WriteLine("Le chien dort ! ");
        }
    }
}
