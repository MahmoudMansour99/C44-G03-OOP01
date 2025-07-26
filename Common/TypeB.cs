using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB()
        {
            // TypeA typeA = new TypeA();
            ////typeA.X = 10;

            //typeA.Y = 10; // Valid because it is internal and in the same project

            //typeA.Z = 20; // valid because it is public
        }
    }
}
