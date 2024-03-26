using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooJ2CSharp
{

    enum Rarety
    {
        common,
        rare,
        legandary
    }
    abstract class Animal
    {   
        public int Id { get; protected set; }
        public string Name { get; protected set;}
        public Rarety Rarety { get; protected set;}

        public abstract void Moove();

        public abstract void Sleep();


    }

}
