using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_firstprog
{
    class Dealer:Customer
    {
        public string Dealer_Code { set; get; }
        public Dealer(string dealer_name, int dealer_age, string code): base(dealer_name,dealer_age)
        {

            Dealer_Code = code;
        }
        public override void Display()
        {
          Console.WriteLine("Displaying derived i.e dealer class method");
        }
    }
}
