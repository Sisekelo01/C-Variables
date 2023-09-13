using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Variables
{
    internal class Program
    {
        static void Main(string[] args)
        { // declaring vaiables
            string name;
                string lastname = "Mthembu";  //declare and intitialize on the same line
            int age;

            // initializing
            name = "Sisekelo";
            age = 14;

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age);

            //change the value of the variables
            name = "kING";
            age = 15;
            Console.WriteLine("He changed his name to " + name + " when he turned " + age);



          Console.ReadLine();
        }
    }
}
