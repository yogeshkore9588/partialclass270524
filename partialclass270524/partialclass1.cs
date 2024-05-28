using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclass270524
{
    public partial class person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {Firstname} {Lastname}");
        }
    }

    public partial class person
    {
        public int Age { get; set; }
        public void DisplayAge()
        {
            Console.WriteLine($"Age: {Age}");
        }
    }
}
