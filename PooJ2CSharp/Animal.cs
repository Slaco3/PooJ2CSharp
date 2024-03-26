using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooJ2CSharp
{
    abstract class Animal
    {
        public string Name { get; protected set;}

        public abstract void Moove();

        public abstract void Sleep();


    }

}
