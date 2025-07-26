using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.User_Defined_Data_Types
{
    internal struct myStruct
    {
         int myAttribute;
        //private int myAttribute;
        //protected public int myAttribute; // Invalid

        public int Id { get; set; }

        void Function()
        {

        }
    }
}
