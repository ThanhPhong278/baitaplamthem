using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle r1 = new rectangle();
            Console.WriteLine("The rectangle has length, width " + r1.getLength() + "," + " " + r1.getWidth() + " "
                + "and area of " + r1.getArea() + " " + "Perimeter " + r1.Perimeter());

            rectangle r2 = new rectangle(2, 6);
            Console.WriteLine("The rectangle has length, width " + r2.getLength() + "," + " " + r2.getWidth() + " "
                + "and area of " + r2.getArea() + " " + "Perimeter " + r2.Perimeter());


            Employees e1 = new Employees(14027, "Hoang", "Trung", 12000000);
            Console.WriteLine("Employee " + "ID:" + e1.getID() + " " + "Name:" + e1.getName() + " " + "Salary:" + e1.getSalary() + " "
                + "Annual Salary:" + e1.getAnnualSalary() + " " + "Raise Salary:" + e1.raiseSalary(10));

            Employees e2 = new Employees(22222, "Teo", "Kun", 10000000);
            Console.WriteLine("Employee " + "ID:" + e2.getID() + " " + "Name:" + e2.getName() + " " + "Salary:" + e2.getSalary() + " "
    + "Annual Salary:" + e2.getAnnualSalary() + " " + "Raise Salary:" + e2.raiseSalary(10));
        }
    }
}
