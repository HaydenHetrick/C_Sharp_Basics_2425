using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics_2425
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataTypes();
            InputOutput();

            Console.ReadKey();
        }

        public static void Comments()
        {
            Console.WriteLine("Comments have slashes.");
            // This is a comment
            /* This 
             * 
             * 
             * 
             * 
             * 
             */
            Console.WriteLine("Multiline Comments start and end with /* */");
        }

        public static void DataTypes()
        {
            int myAge = 18;
            Console.WriteLine(myAge);
            char classGrade = 'A';
            Console.WriteLine(classGrade);

            float myFloat = 123.34F;
            Console.WriteLine(myFloat);

            decimal myDecimal = 86.75309M;
            Console.WriteLine(myDecimal);

            double myDouble = 3.14437832457230450234509823879052789041238;
            Console.WriteLine(myDouble);

            bool myBool = true;
            Console.WriteLine(myBool);

            string myString = "Mr Sekol is cool";
            Console.WriteLine(myString);


        }

        public static void InputOutput()
        {
            Console.WriteLine("What is your name:");
            string playerName = Console.ReadLine();
            Console.Write($"Hello {playerName}. How are you today?");
            // ReadLine takes in strings. So if you want to do math, you have to cast the string to a different datatype.

            // Lets Do Math
            Console.WriteLine("Welcome to my Addition Calculator");
            Console.WriteLine("Please Enter a Number.");
            double num_1 = double.Parse(Console.ReadLine());
            Console.Write("Please Enter a 2nd Number");
            double num_2 = double.Parse(Console.ReadLine());
            double the_sum = num_1 + num_2;
            Console.WriteLine($"{num_1} + {num_2} = {the_sum}");

            Console.WriteLine("Lets Do Multiplication");
            Console.WriteLine("Please Enter a Number");
            double num_3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter a 2nd Number");
            double num_4 = Convert.ToDouble(Console.ReadLine());
            double the_product = num_3 * num_4;
            Console.WriteLine($"{num_3} x {num_4} = {the_sum}");


            Console.ReadLine();

        }
    }
}
