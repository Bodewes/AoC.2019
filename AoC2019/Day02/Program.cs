using System;
using System.Linq;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new Solver();

            var test01 = "1,9,10,3,2,3,11,0,99,30,40,50";
            var test02 = "1,0,0,0,99";
            var test03 = "2,3,0,3,99";
            var test04 = "2,4,4,5,99,0";
            var test05 = "1,1,1,4,99,5,6,0,99";

            //Console.WriteLine($"Part 1: {s.Part1(test01)}");
            //Console.WriteLine($"Part 1: {s.Part1(test02)}");
            //Console.WriteLine($"Part 1: {s.Part1(test03)}");
            //Console.WriteLine($"Part 1: {s.Part1(test04)}");
            //Console.WriteLine($"Part 1: {s.Part1(test05)}");

            var input = "1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,9,1,19,1,9,19,23,1,23,5,27,2,27,10,31,1,6,31,35,1,6,35,39,2,9,39,43,1,6,43,47,1,47,5,51,1,51,13,55,1,55,13,59,1,59,5,63,2,63,6,67,1,5,67,71,1,71,13,75,1,10,75,79,2,79,6,83,2,9,83,87,1,5,87,91,1,91,5,95,2,9,95,99,1,6,99,103,1,9,103,107,2,9,107,111,1,111,6,115,2,9,115,119,1,119,6,123,1,123,9,127,2,127,13,131,1,131,9,135,1,10,135,139,2,139,10,143,1,143,5,147,2,147,6,151,1,151,5,155,1,2,155,159,1,6,159,0,99,2,0,14,0";

            // Part 1
            Console.WriteLine($"Part 1 (12, 2): {s.Part1(input, 12, 2)}");

            // Part 2
            for(int noun = 0; noun < 100; noun++)
            {
                for(int verb = 0; verb < 100; verb++)
                {
                    var result = s.Part1(input, noun, verb);
                    if (result == 19690720)
                    {
                        Console.WriteLine($"Part 2: FOUND {noun}, {verb} => {100 * noun + verb}");
                        continue;
                    }
                }
            }

            Console.ReadLine();
        }
    }

    class Solver
    {
        public int Part1(string input, int noun, int verb)
        {
            return Part1(input.Split(",").Select(x => int.Parse(x)).ToArray(), noun, verb);
        }

        public int Part1(int[] memory, int noun, int verb)
        {
            memory[1] = noun;
            memory[2] = verb;

            int pc = 0;
            do
            {
                //System.Console.WriteLine($"{pc}\t{string.Join(',', memory)}");
                switch (memory[pc])
                {
                    case 1:
                        memory[memory[pc + 3]] = memory[memory[pc + 1]] + memory[memory[pc + 2]];
                        break;
                    case 2:
                        memory[memory[pc + 3]] = memory[memory[pc + 1]] * memory[memory[pc + 2]];
                        break;
                    case 99:
                        return memory[0];
                }
                pc = pc + 4;
            } while (true) ;
           
        }
    }
}
