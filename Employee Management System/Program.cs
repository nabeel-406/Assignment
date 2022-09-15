using Litware_Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO LITWARE ORGANIZATION");
            Console.WriteLine("========================================");

            Console.WriteLine("Enter EMPLOYEE NUMBER");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter EMPLOYEE NAME");
            string name = Console.ReadLine();

            Console.WriteLine("Enter EMPLOYEE SALARY");
            double sal = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(no, name, sal);
            emp.CalculatedSalary();
        }
    }
}
