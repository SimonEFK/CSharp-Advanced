using System;

namespace Date_Modifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstDate = DateTime.Parse(Console.ReadLine());
            var secondDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"{DateModifier.CalculateDaysDifferance(firstDate, secondDate)}");
        }
    }
}
