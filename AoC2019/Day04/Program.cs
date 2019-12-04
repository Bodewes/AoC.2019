using System;
using System.Linq;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new Solver();
            Console.WriteLine($"Part 1: {s.Part1(307237,769058)}");
        }
    }

    /// Part1
    /// It is a six-digit number.
    /// The value is within the range given in your puzzle input.
    /// Two adjacent digits are the same(like 22 in 122345).
    /// Going from left to right, the digits never decrease; they only ever increase or stay the same(like 111123 or 135679).
    /// Part2
    ///  the two adjacent matching digits are not part of a larger group of matching digits

    class Solver
    {
        public int Part1(int min, int max)
        {
            int part1_count = 0;
            int part2_count = 0;
            for (int i = min; i < max; i++)
            {
                var s = i.ToString();

                if (s[0] == s[1] || s[1] == s[2] || s[2] == s[3] || s[3] == s[4] || s[4] == s[5]) // Two adjacent digits are the same
                {
                    if (s[0] <= s[1] && s[1] <= s[2] && s[2] <= s[3] && s[3] <= s[4] && s[4] <= s[5]) // Going from left to right, the digits never decrease;
                    {
                        Console.WriteLine($"Part1 Valid: {s}");
                        part1_count++;

                        // Part2
                        var hist = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        hist[s[0] - '0']++;
                        hist[s[1] - '0']++;
                        hist[s[2] - '0']++;
                        hist[s[3] - '0']++;
                        hist[s[4] - '0']++;
                        hist[s[5] - '0']++;
                        if (hist.Any(x => x == 2))
                        {
                            part2_count++;
                        }
                    }
                }
            }

            Console.WriteLine(part1_count);
            Console.WriteLine(part2_count);

            return part1_count;

        }
    }
}
