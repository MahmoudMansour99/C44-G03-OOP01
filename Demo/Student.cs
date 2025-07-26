using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; } // ? for nullable
        public Gender Gender { get; set; }
        public Grade Grade { get; set; }
        public Branch Branch { get; set; }
    }
}
