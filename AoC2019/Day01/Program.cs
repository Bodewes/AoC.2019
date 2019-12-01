using System;
using System.Collections.Generic;
using System.Linq;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");

            var s = new Solver();
            //var data = new List<string>() { "12", "14", "1969", "100756" };
            var data = System.IO.File.ReadAllLines("data.txt").ToList();
            
            //var part1 = s.Part1(data);
            //Console.WriteLine($"Part 1: {part1}");

            var part2 = s.Part2(data);
            Console.WriteLine($"Part 2: {part2}");


            Console.ReadLine();
        }
    }

    class Solver
    {
        public int Part1(List<string> data)
        {
            var input = data.Select(s => int.Parse(s)/3 - 2);

            foreach(var i in input)
            {
                System.Console.WriteLine(i);
            }

            return input.Sum();
        }
        public int Part2(List<string> data)
        {
            var input = data.Select(s => Part2Helper(int.Parse(s)));

            foreach (var i in input)
            {
                System.Console.WriteLine(i);
            }

            return input.Sum();
        }

        public int Part2Helper(int mass)
        {
            var total = 0;
            var fuel = mass;
            do
            {
                fuel = fuel / 3 - 2;
                total += fuel > 0 ? fuel : 0;

            } while (fuel > 0);
            return total;
        }
    }

}
