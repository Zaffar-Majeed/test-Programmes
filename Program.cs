using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_firstprog
{
    class Program
    {

        static void Main(string[] args)
        {
            

            /*----- Basic of language -----*/
            basicsexample();

            /*----- Object Orientation -----*/

           basicObjectOrientation();

            /*---- Array implementation  -----*/

            arrayexample();

            /*----   list implementation -----*/

            listexample();

            /*---- Queue -----*/
            queueexample();
            


            /*----  Dictionary Implementation-----*/

            dictionaryexample();
            

            /*----  LINQ Implementation-----*/

            linqexapmle();
            
            

            Console.ReadLine();

        }

        private static void basicsexample()
        {
 	        Console.WriteLine("welcome myself to .Net again");
            var x = Console.ReadLine();
            Console.WriteLine("I pressed {0}", x);
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            x = Console.ReadLine();
        }

        private static void basicObjectOrientation()
        {
 	         Customer cust = new Customer();
            cust.setter("rahim");
            Console.WriteLine(cust.getter());

            Customer cust2 = new Customer()
            {
                Age = 23
            };
            Console.WriteLine(cust2.Age);

            Customer cust3 = new Customer("salma", 12);

            Dealer dlr = new Dealer("akib", 23, "00-aaB");
            Console.WriteLine(dlr.Age + "\t" + dlr.name + "\t" + dlr.Dealer_Code);
            dlr.Display();
        }

        private static void arrayexample()
        {
 	         var customers = new Customer[5];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                customers[i] = new Customer();
                customers[i].Age = r.Next();

            }
            foreach (Customer cst in customers)
            {
                Console.WriteLine(cst.Age + "\t");
            }
        }

        private static void listexample()
        {
 	        List<int> customerlist = new List<int>();
                    mylist.Add(5);
                    mylist.Add(3);
                    mylist.RemoveAt(0);
                    foreach (int lst in mylist)
                    {
                        Console.Write(lst + "\t");

                    }

                    List<Customer> customerlist = new List<Customer>();

                    for (int i = 0; i < 5; i++)
                    {
                        Customer cust = new Customer("item-" + i, (i * i + 20));
                        customerlist.Add(cust);
                    }

                    foreach (Customer cust in customerlist)
                    {
                        Console.WriteLine("Name: {0} \t Age: {1}", cust.name, cust.Age);
                    }
        }

        private static void queueexample()
        {
           var myque = new Queue<int>();
            myque.Enqueue(5);
            myque.Enqueue(10);



        private static void dictionaryexample()
        {
            Dictionary<String, Dealer> dealer_list = new Dictionary<string, Dealer>();  // dealer here is a class



            char c = 'A';
            Dealer dlr;
            dlr = new Dealer("cust-name", 20, "dlr-" + c + "-" + 20);
            dealer_list.Add("cat-A", dlr);
            c++;
            dlr = new Dealer("cust-name2", 23, "dlr-" + c + "-" + 23);
            dealer_list.Add("cat-C", dlr);
            c++;
            dlr = new Dealer("cust-name3", 26, "dlr-" + c + "-" + 26);
            dealer_list.Add("cat-D", dlr);
            dlr = dealer_list["cat-D"];

            Console.WriteLine("Value: {0}", dlr.Age);
        }

        private static void linqexapmle()
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            var mylinqquery =
                from num in numbers
                where (num % 2) == 0
                select num;
            foreach (int num in mylinqquery)
            {
                Console.Write("{0}\t", num);
            }
            Customer cust;
            List<Customer> custmoberlist = new List<Customer>();
            for (int i = 0; i < 10; i++)
            {
                cust = new Customer("name-" + i, (2 * i) + i);
                custmoberlist.Add(cust);
            }



            IEnumerable<Customer> customerQuery =
                    from custs in custmoberlist
                    where custs.Age > 10
                    select custs;

            foreach (Customer custs in customerQuery)
            {
                Console.WriteLine(custs.name + "\t " + custs.Age);
            }
        }


    }
}
