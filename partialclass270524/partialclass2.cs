using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclass270524
{
   public partial class Vehicle
    {
        public String Make { get; set; }
        public string Mode1 { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("Make: (Make), Model1: (Model)");
        }
    }

    public partial class Vehicle
    {
        public int Year { get; set; }

        public void DisplayYear()
        {
            Console.WriteLine($"Year: (Year)");
        }
    }

    public partial class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public void DisplayCarInfo()
        {
            DisplayInfo();
            DisplayYear();
            Console.WriteLine($"Number of Doors: (NumberOfDoors)");
        }
    }
}
