using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects1
{
    class Admin
    {
        int id;
        string name;

    internal  void Accept (int id, string name)
            {
              this.id=id;
              this.name =name;
        }

   
        internal  void display()
    {
        Console.WriteLine("your id is {0} and name is {1}", id, name);
    }
}
}
