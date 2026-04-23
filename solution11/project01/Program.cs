namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array can not add after create
            //List data
            //int: datatype
            //list01: list name
            //List<int> list01= new List<int>();

            ////add elements
            //list01.Add(10);
            //list01.Add(10);
            //list01.Add(20);
            //list01.Add(30);
            //list01.Add(40);

            ////PRINT ALL ELEMENTS
            //foreach (int i in list01)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("=========================");

            //to remove elements
            //Add() add elements
            //Remove() remove first wanted elements
            //RemoveAt() remove with index
            //RemoveAll() remove every element applying the condition

            //RemoveAll()
            //try
            //{
            //    list01.RemoveAll(x => x == 10);
            //    foreach(int i in list01)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            // catch (Exception e) {
            //        Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("=========================");


            //Count : number of elements

            //try
            //{
            //list01.Clear();
            //Console.WriteLine(list01.Count);

            //clear() : clear all the list
            //contains(): if element there or not
            //indexof() : return the first index of the element
            //find(): return first element appling the condition
            //exist(): return true or false if htere any element appling the rule

            //Console.WriteLine(list01.Contains(10));

            //    Console.WriteLine(list01.Find(x => x==10));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.WriteLine("=========================");

            //AddRange: add more that element in same time
            //int[] newarr ={ 10, 20, 30, 40, 50, 60 };

            //list01.AddRange(newarr);
            //foreach (int i in list01)
            //{
            //    Console.WriteLine(i);
            //}
            //===============================================================

            //function: code than complier understand to do spisific thing
            //usability
            //scability
            //clean code
            // fast


            //void PrintSum(int x , int y){

            //     Console.WriteLine(x+y);

            // }
            // int fnum= Convert.ToInt32 (Console.ReadLine());
            // int snum= Convert.ToInt32(Console.ReadLine());
            // PrintSum(fnum, snum);



            //=======================================
            bool continueProgram = true;

            // store results here
            List<string> history = new List<string>();

            while (continueProgram)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Choose operation (+, -, *, /): ");
                string op = Console.ReadLine();

                double result = 0;
                bool valid = true;
                string record = "";

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        record = $"{num1} + {num2} = {result}";
                        break;

                    case "-":
                        result = num1 - num2;
                        record = $"{num1} - {num2} = {result}";
                        break;

                    case "*":
                        result = num1 * num2;
                        record = $"{num1} * {num2} = {result}";
                        break;

                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            record = $"{num1} / {num2} = {result}";
                        }
                        else
                        {
                            record = "Error: Division by zero";
                            valid = false;
                        }
                        break;

                 
                }

                history.Add(record);

                Console.Write("Do you want to do another process? (yes/no): ");
                string answer = Console.ReadLine().ToLower();

                if (answer != "yes")
                {
                    continueProgram = false;
                }

                Console.WriteLine();
            }

            // PRINT ALL RESULTS ONLY AT THE END
            Console.WriteLine("=== CALCULATION RESULT ===");
            foreach (string item in history)
            {
                Console.WriteLine(item);
            }

            







            
        }
    }
    }

