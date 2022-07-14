using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static int Mark;
        public char grade;

        static void Main(string[] args)
        {

            Console.WriteLine("Enter marks: ");
            Mark = int.Parse(Console.ReadLine());

            // checking mark is valid or not

            if (Mark < 0 || Mark > 100)
            {
                Console.WriteLine("enter valid mark");


            }


            // for mark greater than 90 less than 100
            if (Mark >= 90 && Mark <= 100)
                Console.WriteLine("your grade is A+");

            // for mark greater than 80 less than 90
            else if (Mark >= 80)
                Console.WriteLine("your grade is A");

            // for mark greater than 70 less than 80
            else if (Mark >= 70)
                Console.WriteLine("your grade is B+");

            // for mark greater than 60 less than 70
            else if (Mark >= 60)
                Console.WriteLine("your grade is B");

            // for mark greater than 50 less than 60
            else if (Mark >= 50)
                Console.WriteLine("your grade is c");

            // for mark less than 50
            else
                Console.WriteLine("your grade is F");




            Console.ReadLine();


        }
    }
}

