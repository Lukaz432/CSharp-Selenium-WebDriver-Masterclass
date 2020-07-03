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
            string userFirstName;
            string age;

            //ask the user a question
            Console.WriteLine("What is your first name?");
            userFirstName = Console.ReadLine();

            //ask the user their age
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            //concatenate the string
            //string response = "Your name is: " + userFirstName + " and you are " + age + " years old";
            string response = $"Your name is: {userFirstName} and you are {age} years old";

            //write out the response
            Console.WriteLine(response);
        }
    }
}
