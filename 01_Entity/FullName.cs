using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entity
{
    public class FullName
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string fullName { get => string.Concat(name, " ", surName); }
    }
}
