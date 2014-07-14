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
           // BasicExample();

            /*----- Object Orientation -----*/

          // BasicObjectOrientation();

            /*---- Array implementation  -----*/

          //  ArrayExample();

            /*----   list implementation -----*/

          //  ListExample();

            /*---- Queue -----*/
          //  QueueExample();
            


            /*----  Dictionary Implementation-----*/

         //   DictionaryExample();
            

            /*----  LINQ Implementation-----*/

            LinqExapmle();
            
            

            Console.ReadLine();

        }

        private static void BasicExample()
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

        private static void BasicObjectOrientation()
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

        private static void ArrayExample()
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

        private static void ListExample()
        {
            List<int> mylist = new List<int>();
 	        List<int> customerlist = new List<int>();
                    mylist.Add(5);
                    mylist.Add(3);
                    mylist.RemoveAt(0);
                    foreach (int lst in mylist)
                    {
                        Console.Write(lst + "\t");

                    }


                    List<Customer> customerlist2 = new List<Customer>();
                    for (int i = 0; i < 5; i++)
                    {
                        Customer cust = new Customer("item-" + i, (i * i + 20));
                        customerlist2.Add(cust);
                    }

                    foreach (Customer cust in customerlist2)
                    {
                        Console.WriteLine("Name: {0} \t Age: {1}", cust.name, cust.Age);
                    }
        }

        private static void QueueExample()
        {
            var myque = new Queue<int>();
            myque.Enqueue(5);
            myque.Enqueue(10);

        }

        private static void DictionaryExample()
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

        private static void LinqExapmle()
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
