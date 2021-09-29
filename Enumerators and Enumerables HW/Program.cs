using System;

namespace Enumerators_and_Enumerables_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region exercise 1

            Console.WriteLine("For loop 10-100");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i * 10);
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            #endregion

            #region exercise 2

            Console.WriteLine("Foreach loop 10-100");

            int[] myIntArr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            foreach (var number in myIntArr)
            {
                Console.Write(number);
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            #endregion

            #region exercise 3

            Console.WriteLine("Foreach loop power of 10");

            var power10 = new PowerOf10(3);
            foreach (var num in power10)
            {
                Console.Write(num);
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            #endregion

            #region exercise 4

            Console.WriteLine("Students who practice alot (grade 10 or above)\n");

            student s1 = new student(11);
            student s2 = new student(5);
            student s3 = new student(37);
            student s4 = new student(50);
            student s5 = new student(8);
            student s6 = new student(10);

            StudentsWhoPracticeALot students = new StudentsWhoPracticeALot(new student[] { s1, s2, s3, s4, s5, s6 });

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            #endregion
        }
    }
}
