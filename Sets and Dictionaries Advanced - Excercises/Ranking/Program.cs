using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictinary_More_Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> studentResults = new Dictionary<string, Dictionary<string, int>>();
            while (input != "end of contests")
            {
                string[] info = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = info[0];
                string password = info[1];

                if (!(contestAndPassword.ContainsKey(contest)))
                {
                    contestAndPassword.Add(contest, password);
                }

                input = Console.ReadLine();

            }
            string inputBeta = Console.ReadLine();

            while (inputBeta != "end of submissions")
            {
                string[] infoBeta = inputBeta.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string currContest = infoBeta[0];
                string currPassword = infoBeta[1];
                bool validInput = (contestAndPassword.ContainsKey(currContest)) && (contestAndPassword[currContest] == currPassword);
                if (validInput)
                {
                    string currStudent = infoBeta[2];
                    int currPoints = int.Parse(infoBeta[3]);
                    if (studentResults.ContainsKey(currStudent) == false)
                    {
                        studentResults.Add(currStudent, new Dictionary<string, int>());
                        studentResults[currStudent].Add(currContest, currPoints);
                    }
                    else
                    {
                        if (studentResults[currStudent].ContainsKey(currContest) == false)
                        {
                            studentResults[currStudent].Add(currContest, currPoints);
                        }
                        else
                        {
                            if (studentResults[currStudent][currContest] < currPoints)
                            {
                                studentResults[currStudent][currContest] = currPoints;
                            }
                        }


                    }


                }


                inputBeta = Console.ReadLine();
            }

            string bestStudent = string.Empty;
            int bestResult = 0;
            int currBestResult = 0;

            foreach (var item in studentResults)
            {


                foreach (var contest in item.Value.OrderByDescending(x => x.Value))
                {
                    currBestResult += contest.Value;

                }
                if (currBestResult >= bestResult)
                {
                    bestResult = currBestResult;
                    bestStudent = item.Key.ToString();
                }
                currBestResult = 0;
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestResult} points.");
            Console.WriteLine($"Ranking: ");


            foreach (var item in studentResults.OrderBy(x => x.Key))
            {

                Console.WriteLine($"{item.Key}");
                foreach (var contest in item.Value.OrderByDescending(x => x.Value))
                {

                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }





        }
    }
}
