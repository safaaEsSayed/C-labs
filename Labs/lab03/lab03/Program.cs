using System.Linq.Expressions;
using System.Transactions;

namespace lab03 {
    internal class program
    {
        static void Main()
        {
            #region Problem_01
            //store grades for many students in one subject (take,print,avg) 
            /*Console.WriteLine("Enter num of students");
            int numOfStudents = int.Parse(Console.ReadLine());
            int[] arr =new int[numOfStudents];
            Console.WriteLine("Enter Grade of student");
            for (int i=0;i< numOfStudents; i++)
            {
                Console.WriteLine($"Grade of student {i+1}= ");
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Grades of students");
            int sum = 0;
            for (int j = 0; j < numOfStudents; j++)
            {
                Console.WriteLine($"Grade of Student{j+1} = {arr[j]}");
                sum += arr[j];
            }
            Console.WriteLine($"Average of grades= {sum/arr.Length}");*/

            #endregion
            #region Problem_02
            //store grades for many students in many subject (take,print,sum(st),avg(sub))
            Console.WriteLine("Enter num of students");
            int numOfStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num of subjects");
            int numOfSubjects = int.Parse(Console.ReadLine());
            int[,] arr = new int[numOfStudents, numOfSubjects];
            Console.WriteLine("Enter Grade of student");
            for (int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine($"Student {i + 1}= ");
                for (int j = 0; j < numOfSubjects; j++)
                {
                    Console.WriteLine($"Grade of student in subject {j + 1}= ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("======================");
            }
            float sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"Student {i + 1}");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($" His grades in subject {j + 1}={arr[i, j]}");
                    sum += arr[i, j];
                }
                Console.WriteLine($" Sum for each student ={sum} ");
                sum = 0;
                Console.WriteLine("------------------------");
            }

            float avg;
            float sumOfSubjects = 0.0f;
            for (int i = 0; i < numOfSubjects; i++)
            {
                for (int j = 0; j < numOfStudents; j++)
                {
                    sumOfSubjects += arr[j, i];
                }
                avg = sumOfSubjects / numOfStudents;
                Console.WriteLine($" Avg for subject {i} ={avg} ");
                sumOfSubjects = 0;

                Console.WriteLine("------------------------");
            }
            #endregion
        }
    }
}
    