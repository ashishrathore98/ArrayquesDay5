using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int noc, nos;
            //Console.WriteLine("Enter Number Of Classes");
            //noc = int.Parse(Console.ReadLine());
            //string[][] students = new string[noc][];
            //for (int i = 0; i < noc; i++)
            //{
            //    Console.WriteLine("Enter Number of Students in Class" + (i + 1));
            //    nos = int.Parse(Console.ReadLine());
            //    students[i] = new string[nos];
            //    for (int j = 0; j < nos; j++)
            //    {
            //        Console.WriteLine($"Enter Student{j + 1}\'s name");
            //        students[i][j] = Console.ReadLine();
            //    }

            //}
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"Students List of Class {i + 1}");
            //    Console.WriteLine("----------------------");
            //    for (int j = 0; j < students[i].Length; j++)
            //    {
            //        Console.WriteLine(students[i][j]);

            //    }
            //    Console.WriteLine("-----------------------");
            //}
            //Console.ReadKey();

            //Day5 Exercise 01

            Console.WriteLine("Enter the number of employees:");
            int numEmployees = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of working days for each employee:");
            int numDays = int.Parse(Console.ReadLine());

            int[][] salaries = new int[numEmployees][];

            // Input salaries for each day
            for (int i = 0; i < numEmployees; i++)
            {
                salaries[i] = new int[numDays];

                Console.WriteLine($"Enter the salaries for employee {i + 1} (separated by spaces):");
                string[] salariesInput = Console.ReadLine().Split(' ');

                for (int j = 0; j < numDays; j++)
                {
                    salaries[i][j] = int.Parse(salariesInput[j]);
                }
            }

            // Calculate total salary for each employee
            int[] totalSalaries = new int[numEmployees];
            for (int i = 0; i < numEmployees; i++)
            {
                int totalSalary = 0;
                for (int j = 0; j < numDays; j++)
                {
                    totalSalary += salaries[i][j];
                }
                totalSalaries[i] = totalSalary;
            }

            // Display the salary table
            Console.WriteLine("Day\t\tTotal Salary");
            for (int j = 0; j < numDays; j++)
            {
                Console.Write($"Day{j + 1}\t\t");
                for (int i = 0; i < numEmployees; i++)
                {
                    Console.Write($"{salaries[i][j]}\t\t");
                }
                Console.WriteLine();
            }

            // Display the total salaries
            Console.WriteLine("Total Salary\t\t");
            for (int i = 0; i < numEmployees; i++)
            {
                Console.Write($"{totalSalaries[i]}\t\t");
            }
            Console.WriteLine();

        }

    }
}
