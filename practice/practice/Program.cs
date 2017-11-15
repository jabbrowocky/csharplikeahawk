using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            float hoursWorked;
            float hourlyWage;
            float wage;
            Console.WriteLine("Please enter your hours worked");
            string userHoursWorked = Console.ReadLine();//captures prompt input as a string variable
            hoursWorked = float.Parse(userHoursWorked); //parses *not best practice* string variable to a float and assigns it to hoursWorked
            Console.WriteLine("Please enter rate of salary");
            string salary = Console.ReadLine();
            hourlyWage = float.Parse(salary);
            wage = hourlyWage * hoursWorked;
            Console.WriteLine("Your paycheck is " + wage);
            Console.ReadKey(); //makes console wait for a key press before closing
            

        }
    }
}
