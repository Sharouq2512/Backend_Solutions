using System.Data;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value dataType
            int x = 10;
            long y = 290738246283;
            short z = 1;
            float b = 2.6f;
            double t = 12.8d;
            decimal e = 23.32m;
            bool hasCar = true;
            char letter = 'd';

            //Referrence DataType
            string name = "Sharouq";

            //single ' ' for char, double " " for string
            var g = 29.3333333334;

            //can not change (Reassign )the value later
            const int i = 40;



            Console.WriteLine("Hello, Enter Number");

            //To read from user
            string username = Console.ReadLine();

            //to print data from user
            Console.WriteLine($"hello {username}");

            //casting
            //Implicit: automatic convert
            //Explicit: 

            //Int to double
            int t1 = 10;
            double result = t1;
            Console.WriteLine(result);
            //------------------------
            //Double to Int
            double t2 = 10.4;
            int s2 = (int)t1;
            Console.WriteLine(s2);
            //-----------------------
            //Double to string
            double t3 = 10.4;
            int s3 = (int)t1;
            Console.WriteLine(s2);
            //------------------------
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myInt); //Int
            Console.WriteLine(myDouble); //Double
                                         //------------------------------------------------
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2;    // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9
                                           //---------------------------------------
            int myInt3 = 10;
            Console.WriteLine(Convert.ToString(myInt3));
            //-----------------------------------
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //-------------------------------------------------------
            //Operators


        }
      
    }
}
