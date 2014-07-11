using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_firstprog
{
    class Customer
    {
         public String name;
         public int Age { get; set; }
        public void setter(String name)
        {
            this.name = name;
        }
        public String getter()
        {
            return name;
        }
        public virtual  void  Display()
        {
            Console.WriteLine("This is base Display");
        }

        public Customer(String nm, int ag)
        {
            name = nm;
            Age = ag;
        }

        public Customer() { }
    }
}
