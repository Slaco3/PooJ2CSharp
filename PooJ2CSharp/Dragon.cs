using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PooJ2CSharp
{
    class Dragon : Animal, IPilotage
    {

        public Dragon()
        {
            this.Name = "Nom random Dragon";
            this.Rarety = Rarety.legandary;

        }
        public Dragon(string name, Rarety rarety, int id)
        {
            this.Id = id;
            this.Name = name;
            this.Rarety = rarety;
        }

        public override void Moove()
        {
            Console.WriteLine("Je suis un dragon qui bouge (depuis animal)");
        }

        public void Moove2()
        {
            Console.WriteLine("Je suis un dragon qui bouge (depuis interface)");
        }

        public override void Sleep()
        {
            Console.Write("Je suis un dragon qui dort");
        }
    }
}
