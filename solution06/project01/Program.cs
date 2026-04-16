using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For loop
            //for (int x =1; x<5 ;x++ )
            //{
            //    Console.WriteLine($"my age is 35");
            //}
            //=================================
            //for (int x = 1; x < 6; x++)
            //{
            //    Console.WriteLine($"enter number");
            //    int number=Convert.ToInt32(Console.ReadLine());
            //}

            //=================================
            //for (int x = 1; x <=5; x++)
            //{
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        Console.WriteLine($"({x},{i})");
            //    }
            //}

            //=================================
            //Console.WriteLine("Pls enter number :");
            //int num = Convert.ToInt32(Console.ReadLine());

            //int cup = 0;

            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        cup++;
            //    }
            //}

            //if (cup == 2)
            //{
            //    Console.WriteLine("The number is Prime");
            //}
            //else
            //{
            //    Console.WriteLine("The number is not Prime");
            //}

            //Console.ReadLine();

            //===================================

            //while loop
            //Console.WriteLine("Pls enter number :");
            //int num = Convert.ToInt32(Console.ReadLine());

            //while (num != 5)
            //{
            //    Console.WriteLine("not correct number");
            //    num = Convert.ToInt32(Console.ReadLine());

            //}

            //===================================
            //Random rnd = new Random();
            //int num = rnd.Next(1,20);
            //while (num != 5)
            //{
            //    Console.WriteLine((num));
            //    Console.WriteLine("not correct number");
            //    num = Convert.ToInt32(Console.ReadLine());

            //}

            //===================================

            //Random rnd = new Random();
            //int num = rnd.Next(1, 10);

            //int i = 0;

            //while (i != num)
            //{
            //    Console.WriteLine("Enter a number: ");
            //    i = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine((num));

            //    if (i != num)
            //    {
            //        Console.WriteLine("Not correct, try again");
            //    }
            //}

            //Console.WriteLine("Correct Number");

            //====================================================

            //Random rnd = new Random();
            //int num = rnd.Next(1, 10);

            //int x = 0;
            //int i = 0;

            //while (x < 3 && i != num)
            //{

            //    Console.WriteLine("Enter a number: ");
            //    i = Convert.ToInt32(Console.ReadLine());

            //    x++;

            //    if (i == num)
            //    {
            //        Console.WriteLine("Correct");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong");
            //    }
            //}

            //if (i != num)
            //{
            //    Console.WriteLine("Wrong, correct number was: " + num);
            //}


            //=======================================
            //do while
            //Console.WriteLine("Enter a number: ");
            //i = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine("Enter a number: ");
            //    i = Convert.ToInt32(Console.ReadLine());
            //}
            //while (i !=5)

            //========================================
            //String (immutable data type)

            //String text = "Hello ";

            //text += "World";
            //for (int i = 0; i < text.Length; i++) {
            //    Console.WriteLine(text[i]);
            //}
            //========================================
            ////concatination

            //String text01 = "Hello ";
            //String text02 = "World";
            //String text03 = text01 + text02;

            //=======================================


            //Functions
            //String text01 = "  He ll o ";
            //String text02 = "World";
            //Console.WriteLine(text02);
            //Console.WriteLine(text02[0]);
            //Console.WriteLine(text01.Length);
            //Console.WriteLine(text01.ToUpper());
            //Console.WriteLine(text01.Trim());
            //Console.WriteLine(text01.TrimStart());
            //Console.WriteLine(text01.TrimEnd());
            //Console.WriteLine(text01.ToLower());
            //Console.WriteLine(text01.Contains('a'));
            //Console.WriteLine(text01.Replace("World", "me"));
            //Console.WriteLine(text02.Substring(0,3));


            //=====================================

            //String builders

            //StringBuilder newText = new StringBuilder();
            //Console.WriteLine(newText.Append("Sharouq "));
            //Console.WriteLine("============================");
            //Console.WriteLine(newText.Append("AlBadi"));
            //=========================================================

            //StringBuilder newText = new StringBuilder();
            //Console.WriteLine(newText.AppendLine("Sharouq "));
            //Console.WriteLine("============================");
            //Console.WriteLine(newText.AppendLine("AlBadi"));

            //Console.WriteLine(newText.Insert(5, "Ali"));
            //Console.WriteLine(newText.Remove(10,6));
            //Console.WriteLine(newText.Replace("AlBadi","Ahmed"));


            //=========================================================
            //Console.WriteLine("Pls enter name :");
            //String name = Console.ReadLine();
            //StringBuilder newText = new StringBuilder();
 
            
            //for (int i = name.Length -1; i >= 0; i--)
            //{
            //    newText.Append(name[i]);

            //}
            //if (name ==newText.ToString())
            //{
            //    Console.WriteLine("Perfect");
            //}
            //else
            //{
            //    Console.WriteLine("Not Perfect");
            //}
            //===================================
            //Other soulution
            //Console.WriteLine("Pls enter name :");
            //String x = "";
            //String name = Console.ReadLine();
            //StringBuilder newText = new StringBuilder();


            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    x+= name[i];

            //}
            //if (name == x)
            //{
            //    Console.WriteLine("Perfect");
            //}
            //else
            //{
            //    Console.WriteLine("Not Perfect");
            //}

        }
    }
}
