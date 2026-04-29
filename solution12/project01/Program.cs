using System.Collections;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LIFO
            ////Stack: last in first out LIFO
            //Stack<int> numbers = new Stack<int>(); //genaric
            ////add elements
            //numbers.Push(1);
            //numbers.Push(2);
            //numbers.Push(3);
            //numbers.Push(4);

            ////delete last element
            //numbers.Pop();

            //// return last element
            //// store prosses like Ctrl+Z to return last prosses I did
            //Console.WriteLine(numbers.Peek());
            ////===============================
            #endregion

            #region FIFO
            ////queue: first in  first out FIFO
            //Queue<String> names = new Queue<String>();
            ////Enqueue == push
            ////Dequeue == pop
            ////peek
            ////count

            //names.Enqueue("Sharouq");
            //names.Enqueue("Shahad");
            //names.Enqueue("Tasnim");
            //Console.WriteLine(names.Peek());
            #endregion



            Stack<string> stack = new Stack<string>();

            
            stack.Push("Salim");
            stack.Push("Ali");
            stack.Push("Ahmed");
            stack.Push("Mohammed");
            stack.Push("Abdullah");

            int choice;

            do
            {
                Console.WriteLine("\n1. Add String");
                Console.WriteLine("2. Print Strings");
                Console.WriteLine("3. Delete Last Element");
                Console.WriteLine("4. Show All Elements");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        stack.Push(name);
                        break;

                    case 2:
                        if (stack.Count > 0)
                            Console.WriteLine("Top: " + stack.Peek());
                        else
                            Console.WriteLine("Stack is empty");
                        break;

                    case 3:
                        if (stack.Count > 0)
                            Console.WriteLine("Removed: " + stack.Pop());
                        else
                            Console.WriteLine("Stack is empty");
                        break;

                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine("All elements:");
                            foreach (var item in stack)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                            Console.WriteLine("Stack is empty");
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 5);


            #region Dictionary

            //Dictionary<String,int> StudData= new Dictionary<String,int>();
            ////Add data
            //StudData.Add("Ali", 25);
            //StudData.Add("Salim", 27); 

            ////Print age
            //Console.WriteLine($"Ali is " + StudData["Ali"]+ " Years old");

            ////Update age
            //StudData["Ali"] = 33;
            //Console.WriteLine($"Ali is " + StudData["Ali"] + " Years old");

            //// remove 
            //StudData.Remove("Ali");
            //Console.WriteLine(StudData.ContainsKey("Ali"));
            //Console.WriteLine(StudData.ContainsValue(33));
            #endregion




        }

    }
}
