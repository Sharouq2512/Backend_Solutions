using System;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = 5;
            int subjects = 3;

            string[] subjectNames = { "Math", "Science", "English" };

            // =========================
            // PART 1
            
            string[] students = new string[studentsCount];

            Console.WriteLine("Enter 5 student names:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");
                students[i] = Console.ReadLine();
            }

            // =========================
            // PART 2
            
            int[,] grades = new int[studentsCount, subjects];

            Console.WriteLine("\nEnter grades:");

            for (int i = 0; i < studentsCount; i++)
            {
                Console.WriteLine($"\n{students[i]}:");

                for (int j = 0; j < subjects; j++)
                {
                    Console.Write($"{subjectNames[j]}: ");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // =========================
            // PART 3 and 4
            
            Console.WriteLine("\n--- Grades Table ---");

            Console.Write("Student\t");
            for (int j = 0; j < subjects; j++)
            {
                Console.Write(subjectNames[j] + "\t");
            }
            Console.WriteLine("Average");

            for (int i = 0; i < studentsCount; i++)
            {
                Console.Write($"{students[i]}\t");

                int sum = 0;

                for (int j = 0; j < subjects; j++)
                {
                    Console.Write(grades[i, j] + "\t");
                    sum += grades[i, j];
                }

                double avg = (double)sum / subjects;
                Console.WriteLine(avg);
            }

            // =========================
            // PART 5
            Console.WriteLine("\n--- Jagged Array (from 2D grades) ---");

            int[][] jagged = new int[studentsCount][];

            // convert 2D array → jagged array
            for (int i = 0; i < studentsCount; i++)
            {
                jagged[i] = new int[subjects];

                for (int j = 0; j < subjects; j++)
                {
                    jagged[i][j] = grades[i, j];
                }
            }

            // display
            for (int i = 0; i < studentsCount; i++)
            {
                Console.WriteLine($"\nStudent: {students[i]}");
                Console.WriteLine("Number of subjects: " + jagged[i].Length);

                Console.Write("Grades: ");

                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }

                Console.WriteLine();
            }
            //==============================
            // PART 6
            Console.Write("\nEnter student name to search: ");
            string searchName = Console.ReadLine();

            int index = -1;

            for (int i = 0; i < studentsCount; i++)
            {
                if (students[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
                Console.WriteLine($"Student found at index: {index}");
            else
                Console.WriteLine("Student not found.");


            //======================
            // PART 7
            int highest = grades[0, 0];

            for (int i = 0; i < studentsCount; i++)
            {
                for (int j = 0; j < subjects; j++)
                {
                    if (grades[i, j] > highest)
                    {
                        highest = grades[i, j];
                    }
                }
            }

            Console.WriteLine($"\nHighest grade in system: {highest}");
        }
    }
}