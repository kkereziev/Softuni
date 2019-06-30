using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            int numberOfSheets = int.Parse(Console.ReadLine());
            double areaOfSheet = double.Parse(Console.ReadLine());
            double area = sizeOfSide * sizeOfSide * 6;
            double covarage = 0;
            for (int i = 1; i <= numberOfSheets; i++)
            {
                if (i % 3 == 0)
                {
                    double percent = areaOfSheet * 0.25;
                    covarage += percent;
                }
                else
                {
                    covarage += areaOfSheet;
                }
            }
            double overallPercent = covarage / area;
            overallPercent *= 100;
            Console.WriteLine($"You can cover {overallPercent:f2}% of the box.");
        }
    }
}
