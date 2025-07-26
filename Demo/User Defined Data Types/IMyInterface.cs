using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.User_Defined_Data_Types
{
    internal interface IMyInterface
    {
        int Id { get; set; } // Invalid
        void Pint(); // Signature without a body or implementation

        private void Fun01()
        {
            Console.WriteLine("Function01");
        }
    }
}
