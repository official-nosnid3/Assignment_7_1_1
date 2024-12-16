using System.Text;

namespace Assignment_7_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 7.1.1
             * 
             * You are a student who has recently taken an exam with your classmates. However, the professor has 
             * not yet provided the students with a sorted list of exam scores. To make things easier, 
             * you write a program to sort exam scores in ascending order using the selection sort algorithm. 
             * This way, you can obtain the sorted list of scores and see how you performed compared to 
             * your classmates. Also, you choose selection sort since that is an easy way of implementation.
             */

            int[] grades = { 88, 90, 91, 87, 79, 82, 82 };
            int myGrade = 88;
            int place = 0;

            Console.Write("The professor had the following grades: ");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"{grades[i]} ");
            }

            SelectionSort(grades);

            Console.Write("\nYour code sorted the grades to: ");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"{grades[i]} ");

                if (grades[i] == myGrade)
                    place = grades.Length - i;
            }

            Console.WriteLine($"\nYour grade was {myGrade}, scoring in place {place} out of {grades.Length} students");
            Console.ReadLine();
        }

        static void SelectionSort(int[] ints)
        {
            int n = ints.Length;
            // Out loop will give us the starting value that will be compared to every other value
            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                // Inner loop will iterate through every other value in the array
                for (int j = i + 1; j < n; j++)
                {
                    // Check if the value at j index is lower than the value we started with
                    if (ints[j] < ints[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the values of the starting value and the new lowest value
                int temp = ints[i];
                ints[i] = ints[minIndex];
                ints[minIndex] = temp;
            }
        }
    }
}
