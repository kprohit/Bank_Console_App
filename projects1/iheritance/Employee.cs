using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects1
{
    class Employee:Admin
    {
        int salary;

      internal  void Accept1(int salary)
        {
            this.salary = salary;
        }

   internal  void display1()
        {
            Console.WriteLine("Your salary is"+salary);
        }

        public static void Main()
        {

            Employee obj = new Employee();
            obj.Accept(25, "kalpesh");
            obj.display();
            obj.Accept1(20000);
            obj.display1();
            Console.ReadLine();
        }
    }
}
