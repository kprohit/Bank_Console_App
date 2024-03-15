
using System;

namespace projects1
{
    class Sampleprogram
    {
        public static void Main()
        {
            try
            { 
            int a = 20, b = 0;
            int c;

            Console.WriteLine("enter the value of a");
            b = Convert.ToInt32(Console.ReadLine());
            c = a / b;
            Console.WriteLine("value of c is: "+c);
            Console.ReadKey();
            }
            catch(DivideByZeroException )
            {
                Console.WriteLine("please enter the non zero vlaue only ");
            }

            Console.ReadKey();

        }
    }
}
