using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesOfFrogs = Console.ReadLine().Split(" ").ToList();
            while (true)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split(" ");
                string name;
                int index;
                switch (commandArgs[0])
                {
                    case "Join":
                        name = commandArgs[1];
                        if (!namesOfFrogs.Contains(name))
                        {
                            namesOfFrogs.Add(name);
                        }
                        break;

                    case "Jump":
                        name = commandArgs[1];
                        index = int.Parse(commandArgs[2]);
                        if (index >= 0 && index <= namesOfFrogs.Count - 1)
                        {
                            namesOfFrogs.Insert(index, name);
                        }
                        break;

                    case "Dive":
                        index = int.Parse(commandArgs[1]);
                        if (index >= 0 && index <= namesOfFrogs.Count - 1)
                        {
                            namesOfFrogs.RemoveAt(index);
                        }
                        break;

                    case "First":
                        int count = int.Parse(commandArgs[1]);
                        if (count <= namesOfFrogs.Count - 1)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                Console.Write(namesOfFrogs[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        else if (count > namesOfFrogs.Count - 1)
                        {
                            count = namesOfFrogs.Count;
                            for (int i = 0; i < count; i++)
                            {
                                Console.Write(namesOfFrogs[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "Last":
                        count = int.Parse(commandArgs[1]);
                        if (count <= namesOfFrogs.Count - 1)
                        {
                            int currentIndex = namesOfFrogs.Count - 1 - count;
                            for (int i = currentIndex + 1; i < namesOfFrogs.Count; i++)
                            {
                                Console.Write(namesOfFrogs[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        else if (count > namesOfFrogs.Count - 1)
                        {
                            count = 0;
                            for (int i = 0; i < namesOfFrogs.Count; i++)
                            {
                                Console.Write(namesOfFrogs[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "Print":
                        string word = commandArgs[1];
                        if (word == "Normal")
                        {
                            Console.Write("Frogs: ");
                            Console.WriteLine(string.Join(" ", namesOfFrogs));
                        }
                        else if (word == "Reversed")
                        {
                            namesOfFrogs.Reverse();
                            Console.Write("Frogs: ");
                            Console.WriteLine(string.Join(" ", namesOfFrogs));
                        }
                        return;
                }
            }
        }
    }
}
