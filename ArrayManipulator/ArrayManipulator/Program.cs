using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().ToLower().Split(" ").ToArray();
            int index = 0;
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "exchange":
                        index = int.Parse(command[1]);
                        if (index > array.Length - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            ExchangeArray(array, index);
                        }
                        break;
                    case "max":
                        switch (command[1])
                        {
                            case "even":
                                MaxEvenElement(array);
                                break;
                            case "odd":
                                MaxOddElement(array);
                                break;
                        }
                        break;
                    case "min":
                        switch (command[1])
                        {
                            case "even":
                                MinEvenNumber(array);
                                break;
                            case "odd":
                                MinOddNumber(array);
                                break;
                        }
                        break;
                    case "first":
                        int convert = Convert.ToInt32(command[1]);
                        switch (command[2])
                        {
                            case "even":
                            case "odd":
                                FirstEvenОrOddNumber(array, command[2], convert, myList);
                                break;
                        }
                        break;
                    case "last":
                        int convert2 = Convert.ToInt32(command[1]);
                        LastEvenОrOddNumber(array, command[2], convert2);
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            if (command[0] == "end")
            {
                Console.WriteLine($"[{string.Join(", ", array)}]");
            }
        }

        static void ExchangeArray(int[] array, int index)
        {
            for (int i = 0; i < index + 1; i++)
            {
                int firstNum = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = firstNum;
            }
        }

        static void MaxEvenElement(int[] array)
        {
            int maxElement = array[0];
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= maxElement)
                    {
                        maxElement = array[i];
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MaxOddElement(int[] array)
        {
            int maxElement = array[0];
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    if (array[i] >= maxElement)
                    {
                        maxElement = array[i];
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MinEvenNumber(int[] array)
        {
            int minElement = array[0];
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= minElement)
                    {
                        minElement = array[0];
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void MinOddNumber(int[] array)
        {
            int minElement = array[0];
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    if (array[i] <= minElement)
                    {
                        minElement = array[0];
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void FirstEvenОrOddNumber(int[] array, string command, int count, List<int> myList)
        {
            int[] tempArr = new int[count];
            int counter = 0;
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (command == "even")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            tempArr[counter] = array[i];
                            counter++;
                            if (counter == count)
                            {
                                break;
                            }
                        }
                    }
                }
                else if (command == "odd")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 1)
                        {
                            tempArr[counter] = array[i];
                            counter++;
                            if (counter == count)
                            {
                                break;
                            }
                        }
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    foreach (var item in tempArr)
                    {
                        if (item != 0)
                        {
                            myList.Add(item);
                        }
                    }
                    Console.WriteLine($"[{string.Join(", ", myList)}]");
                }
            }
        }

        static void LastEvenОrOddNumber(int[] array, string command, int count)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (command == "odd")
                {
                    int counter8 = 0;
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] % 2 != 0)
                        {
                            counter8++;
                        }
                    }
                    int[] OddArr = new int[counter8];
                    counter8 = 0;
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (array[k] % 2 != 0)
                        {
                            OddArr[counter8] = array[k];
                            counter8++;
                        }
                    }

                    if (count >= OddArr.Length)
                    {
                        Console.WriteLine($"[{string.Join(", ", OddArr)}]");
                    }
                    else
                    {
                        int[] temp = new int[count];

                        for (int i = 0; i < count; i++)
                        {
                            temp[i] = OddArr[OddArr.Length - count + i];
                        }

                        Console.WriteLine($"[{string.Join(", ", temp)}]");
                    }

                }
                else
                {
                    int counter8 = 0;

                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] % 2 == 0)
                        {
                            counter8++;
                        }
                    }

                    int[] evenArr = new int[counter8];

                    counter8 = 0;

                    for (int k = 0; k < array.Length; k++)
                    {
                        if (array[k] % 2 == 0)
                        {
                            evenArr[counter8] = array[k];
                            counter8++;
                        }
                    }

                    if (count >= evenArr.Length)
                    {
                        Console.WriteLine($"[{string.Join(", ", evenArr)}]");
                    }
                    else
                    {
                        int[] temp = new int[count];

                        for (int i = 0; i < temp.Length; i++)
                        {
                            temp[i] = evenArr[evenArr.Length - count + i];
                        }

                        Console.WriteLine($"[{string.Join(", ", temp)}]");
                    }
                }
            }
        }
    }
}

