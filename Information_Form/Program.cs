using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Form
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            String age  = "";
            String address = "";
            String contact_no = "";

            Console.WriteLine("Please Write your Name ");
            name = Console.ReadLine();

            Console.WriteLine("Please Write your Age ");
            age = Console.ReadLine();

            Console.WriteLine("Please Write your Address ");
            address = Console.ReadLine();

            Console.WriteLine("Please Write your Contact_no ");
            contact_no = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Name       :" + name +".");
            Console.WriteLine("Age        :" + age );
            Console.WriteLine("Address    :" + address +".");
            Console.WriteLine("Contact_no :" + contact_no);

            Console.ReadKey();



        }
    }
}
