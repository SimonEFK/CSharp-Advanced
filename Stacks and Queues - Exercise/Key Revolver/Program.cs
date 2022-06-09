using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int pricePerBullet = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int[] shotsArrey = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locksArrey = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isUnlocked = false;
            Stack<int> shots = new Stack<int>(shotsArrey);
            Queue<int> locks = new Queue<int>(locksArrey);
            int bulletsLost = 0;
            int totalBulletsLost = 0;
            int price = int.Parse(Console.ReadLine());
            while (locks.Count > 0 && shots.Count > 0)
            {
                int currShot = shots.Pop();
                bulletsLost++;
                totalBulletsLost++;
                int currLock = locks.Peek();
                if (currShot <= currLock)
                {
                    Console.WriteLine($"Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Ping!");
                }
                if (bulletsLost == size&&shots.Count>0)
                {
                    Console.WriteLine($"Reloading!");
                    bulletsLost = 0;
                }
            }
            if (locks.Count <= 0)
            {
                isUnlocked = true;
            }
            if (isUnlocked == true)
            {
                Console.WriteLine($"{shots.Count} bullets left. Earned ${price - pricePerBullet * totalBulletsLost}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
