using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class User
    {
        public int Id { get; set; }
        //public bool[] Permessions { get; set; } = new bool[4];
        public Permissions Permissions { get; set; }
    }
}
