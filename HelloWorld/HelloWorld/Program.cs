using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            //variables
            string itemName = "Widget";
            double pricePerOunce = 17.36;
            string outputString;

            //format output
            //the {0:C} doesn't show the $ sign in front of pricePerOunce, instead, what it shows is "17,36 ?"
            outputString = String.Format("{0,10},{1,10}", itemName, pricePerOunce);

            //output to the user
            //we might also input actual strings instead of variables
            Console.WriteLine(String.Format("{0,10},{1,10}", "Item Name", "Price"));
            Console.WriteLine(outputString);
        }
    }
}
