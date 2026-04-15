using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////control statements
            ////1. conditional statements (if , switch)
            ////2. loop statements


            ////if statement
            //int x = 20;
            //if (x > 50)
            //{
            //    Console.WriteLine("yellow");
            //}
            //else if (x>40)
            //{
            //    Console.WriteLine("green");
            //}
            //else if (x > 0)
            //{
            //    Console.WriteLine("red");
            //}
            ////=============================

            //Console.WriteLine("pleace enter your child gender");
            //string gender = Console.ReadLine();

            //Console.WriteLine("please enter your child age");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (gender == "boy")
            //{
            //    if (age > 16 || age < 4)
            //    {
            //        Console.WriteLine("we do not accept boys older than 16");
            //    }
            //    else if (age > 12)
            //    {
            //        Console.WriteLine("football");
            //    }
            //    else if (age > 9)
            //    {
            //        Console.WriteLine("swimming");
            //    }
            //    else
            //    {
            //        Console.WriteLine("reading");
            //    }
            //}

            //else if (gender == "girl")
            //{
            //    if (age > 16 || age < 4)
            //    {
            //        Console.WriteLine("we do not accept girls older than 16");
            //    }
            //    else if (age > 12)
            //    {
            //        Console.WriteLine("dancing");
            //    }
            //    else if (age > 9)
            //    {
            //        Console.WriteLine("swimming");
            //    }
            //    else
            //    {
            //        Console.WriteLine("rally");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter boy or girl");
            //}

            //==========================================================
            //Task 1
            Console.WriteLine("please enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("number is negative");
            }
            else if (number == 0)
            {
                Console.WriteLine("number is zero");
            }

            //=========================================================
            //Task 2
            Console.WriteLine("please enter integer");
            int integer = Convert.ToInt32(Console.ReadLine());
            if (integer % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            //==========================================================
            //Task 3
            Console.WriteLine("please enter student score from 0-100");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("gragde is excellent");
            }
            else if (score >= 75 && score <= 89)
            {
                Console.WriteLine("grade is very good");
            }
            else if (score >= 60 && score <= 74)
            {
                Console.WriteLine("grade is good");
            }
            else if (score >= 50 && score <= 59)
            {
                Console.WriteLine("pass");
            }
            else if (score >= 0 && score < 50)
            {
                Console.WriteLine("fail");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            //===================================================
            //Task 4
            Console.WriteLine("pleace enter username");
            string username = Console.ReadLine();

            Console.WriteLine("please enter your password");
            int password = Convert.ToInt32(Console.ReadLine());

            if (username == "admin" && password == 1234)
            {
                Console.WriteLine("login successful");
            }
            else
            {
                Console.WriteLine("invalid username or password");
            }

            //=====================================================

            //Task5
            int balance = 1000;

            Console.Write("Enter withdrawal amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

                if (amount <= 0)
                {
                    Console.WriteLine("Invalid Amount");
                }
                else if (amount > balance)
                {
                    Console.WriteLine("Insufficient Balance");
                }
                else
                {
                    balance = balance - amount;
                    Console.WriteLine("Withdrawal Successful");
                    Console.WriteLine("Remaining Balance: " + balance );
                }
            }
            


            //================================================
            //#region switch
            //string fruits = "Apple";
            //switch (fruits)
            //{
            //    case "orange":
            //        Console.WriteLine("hello word");
            //        break;

            //    case "banana":
            //        Console.WriteLine("hi");
            //        break;

            //    case "Apple":
            //        Console.WriteLine("it is apple");
            //        break;




            //}

            //#endregion












        }

    }
}
