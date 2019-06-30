using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tasks = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command;
            int countCompleted = 0;
            int countIncompleted = 0;
            int countDroped = 0;
            if (tasks.Count > 0)
            {
                while ((command = Console.ReadLine()) != "End")
                {
                    string[] commandArgs = command.Split(" ");
                    int index;
                    switch (commandArgs[0])
                    {
                        case "Complete":
                            index = int.Parse(commandArgs[1]);
                            if (index >= 0 && index <= tasks.Count - 1)
                            {
                                tasks[index] = 0;
                            }
                            break;
                        case "Change":
                            index = int.Parse(commandArgs[1]);
                            int time = int.Parse(commandArgs[2]);
                            if (index >= 0 && index <= tasks.Count - 1)
                            {
                                tasks[index] = time;
                            }
                            break;
                        case "Drop":
                            index = int.Parse(commandArgs[1]);
                            if (index >= 0 && index <= tasks.Count - 1)
                            {
                                tasks[index] = -1;
                            }
                            break;
                        case "Count":
                            string word = commandArgs[1];
                            if (word == "Completed")
                            {
                                for (int i = 0; i < tasks.Count; i++)
                                {
                                    if (tasks[i] == 0)
                                    {
                                        countCompleted++;
                                    }
                                }
                                Console.WriteLine(countCompleted);
                            }
                            else if (word == "Incomplete")
                            {
                                for (int i = 0; i < tasks.Count; i++)
                                {
                                    if (tasks[i] != 0 && tasks[i] != -1)
                                    {
                                        countIncompleted++;
                                    }
                                }
                                Console.WriteLine(countIncompleted);

                            }
                            else if (word == "Dropped")
                            {
                                for (int i = 0; i < tasks.Count; i++)
                                {
                                    if (tasks[i] == -1)
                                    {
                                        countDroped++;
                                    }
                                }
                                Console.WriteLine(countDroped);
                            }
                            break;
                    }
                }
                foreach (var item in tasks)
                {
                    if (item > 0 && item <= 5)
                    {
                        Console.Write(item + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}