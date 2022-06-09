using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!(grades.ContainsKey(studentName)))
                {
                    grades.Add(studentName, new List<decimal>() { grade });
                }
                else
                {
                    grades[studentName].Add(grade);
                }
            }
            foreach (var item in grades)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ",item.Value.Select(x=>$"{x:f2}"))} (avg: {item.Value.Average():F2})");
            }
        }
    }
}
