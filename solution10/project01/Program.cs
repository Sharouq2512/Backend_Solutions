using System.Diagnostics;
using System.IO;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //library: codes in same language we use it always so we put it in library
            //system.input out: codes to create object

            //File.Create("test01.txt");


            //File.WriteAllText("test01.txt", "Hello from C#");
            //Enter data in file
            String[] lines =
            {
                "Sharouq",
                "Shahad",
                "Tasnim"
            };

            //write this lines in file
            //File.WriteAllLines("test01.txt", lines);


            String[] lines02 = { "Ahmed", "Ali" };
            //File.WriteAllLines("test01.txt", lines02);    
            //File.AppendAllText("text02.txt", "\n Hello from here");
            Console.WriteLine("Hello");

            //=======
            //read Data

            //read all file
            //String myfile = File.ReadAllText("text02.txt");
            //Console.WriteLine(myfile);

            //Read line by line
            //String[] mylines = File.ReadAllLines("text02.txt");
            //Console.WriteLine(mylines[3]);

            //String myfile = File.ReadAllText("report.txt");
            //Console.WriteLine(myfile);
            //==================================================

            //File.Create("report2.txt");
            //String myfile = File.ReadAllText("report2.txt");
            //Console.WriteLine(myfile);
            //File.Delete("report2.txt");
            //Console.WriteLine(File.Exists("report2.txt"));
            //if (File.Exists("The file id here"))
            //{
            //    Console.WriteLine("File is here");
            //}
            //else
            //{
            //    Console.WriteLine("File is not here");
            //}
            //=====================================

            //try
            //{
            //    File.Delete("report2.txt");
            //    if (File.Exists("The file id here"))
            //    {
            //        Console.WriteLine("File is here");
            //    }
            //    else
            //    {
            //        Console.WriteLine("File is not here");
            //    }
            //}
            //catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //}

            //to copy data from file and create a copy file
            //try
            //{
            //    File.Copy("text02.txt", "copy01.txt");
            //    Console.WriteLine(File.ReadAllLines("copy01.txt"));


            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //move file : delete file and move data in other file
            //try
            //{
            //    File.Move("text02.txt", "move01.txt");



            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine(File.ReadAllLines("move01.txt"));


            //==================================================
            //Task
            File.WriteAllText("exam1.txt", "This is exam 1");
            File.WriteAllText("exam2.txt", "This is exam 2");
            File.WriteAllText("exam3.txt", "This is exam 3");

            Console.WriteLine("Choose exam: ");
            string input = Console.ReadLine();

            string name = "";

            switch (input)
            {
                case "1":
                    name = "exam1.txt";
                    break;
                case "2":
                    name = "exam2.txt";
                    break;
                case "3":
                    name = "exam3.txt";
                    break;
            }

           

            try
            {
                Process.Start("notepad.exe", name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
