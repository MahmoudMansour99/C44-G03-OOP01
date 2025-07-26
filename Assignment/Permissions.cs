using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    [Flags]
    internal enum Permissions:byte
    {
        None = 0,
        Read = 1, 
        Write = 2, 
        Delete = 4, 
        Execute = 8
    }
}
