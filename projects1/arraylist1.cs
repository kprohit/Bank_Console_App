using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects1
{
    class arraylist1
    {
        public static void Main()
        {

            ArrayList kp = new ArrayList();

            //kp.Add(6);
            kp.Add("kp");
            kp.Add(7);
            kp.Add("kalpesh");
            kp.Add("kalpesh rohit");
            kp.Add(777);

            foreach (string item in kp)
            {
                Console.WriteLine(item);
             }

            //Console.ReadKey();
            Console.ReadLine();

        }
    }
}
