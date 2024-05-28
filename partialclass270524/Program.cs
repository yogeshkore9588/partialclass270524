using static partialclass270524.Access;

namespace partialclass270524
{
    internal class Program
    {
         public static void Main(string[] args)
        {
            //person person = new person
            //{
            //    Firstname = "Kohli",
            //    Lastname = "Virat",
            //    Age = 30
            //};
            //person.DisplayFullName();
            //person.DisplayAge();


            //Car car = new Car
            //{
            //Make="Toyota",
            //Model1 = "Camry",
            //  Year=2021,
            //    NumberOfDoors=4
            //};
            //car.DisplayInfo();

            {
                Employee emp = new Employee();

                emp.Id = 1;
                emp.Name = "Virat Kohli";
                emp.Salary = 50000;

                Console.WriteLine("Employee ID: " + emp.Id);
                Console.WriteLine("Employee Name: " + emp.Name);
                Console.WriteLine("Employee Salary: " + emp.Salary);
            }
        }
    }
}
