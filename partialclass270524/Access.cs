using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclass270524
{
    internal class Access
    {
        public partial class Employee
        {
            // Private fields
            private int id;
            private string name;
            private decimal salary;
        }
        public partial class Employee
        {
            // Public properties to access the private fields
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public decimal Salary
            {
                get { return salary; }
                set { salary = value; }
            }
        }
    }
}
