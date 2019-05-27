using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkaman
{
    class Program
    {
        static void Main(string[] args)
        {
            //accepting an input from the user
            Console.WriteLine("Enter Tshirt Name: ");
            string tname = Console.ReadLine();
            Console.WriteLine("Enter Tshirt Type: ");
            string ttype = Console.ReadLine();
            Console.WriteLine("Enter Tshirt Size: ");
            string tsize = Console.ReadLine();

            //assigning input to a class
            var obj = new tshirt()
            {
                Productname = tname,
                type = ttype,
                size = tsize

            };
            //display results
            Console.WriteLine("_________________________________________________\n");
            Console.WriteLine("RESULTS FOR SHIRTS\n");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(obj.Basket());

            //calling for pants input
            Console.WriteLine("_________________________________________________\n");
            Console.WriteLine("Enter Pants Name: ");
            string pname = Console.ReadLine();
            Console.WriteLine("Enter Pants Type: ");
            string ptype = Console.ReadLine();
            Console.WriteLine("Enter Pants Size: ");
            string psize = Console.ReadLine();
            Console.WriteLine("_________________________________________________\n");

            //assigning input to a class
            var pobj = new pants()
            {
                Productname = pname,
                type = ptype,
                size = psize

            };
            //display results
            Console.WriteLine("_________________________________________________\n");
            Console.WriteLine("RESULTS FOR PANTS\n");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(pobj.Basket());
            Console.WriteLine("_________________________________________________\n");
            
            //get the sum
            double sum = Convert.ToDouble(obj.totalp) + Convert.ToDouble(pobj.totalp);

            Console.WriteLine("Total for Items in the Basket is:      " + sum);
            Console.ReadKey();

        }
    }
}
