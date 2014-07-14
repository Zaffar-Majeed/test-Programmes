
namespace My_firstprog
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer
    {
        
        
         public Customer() 
         { 

         }
         public Customer(String name, int age)
         {
             this.Name = name;
             this.Age = age;
         }

         public String Name;

       
        public int Age { get; set;   }

        public void Setter(String name)
        {
            this.Name = name;
        }

               
        public String Getter()
        {
            return Name;
        }

        public virtual void Display()
        {
          Console.WriteLine("This is base Display");
        }

    }

}
