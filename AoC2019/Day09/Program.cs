using System;
using System.Collections.Generic;
using System.Linq;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            long[] test01 = { 109, 1, 204, -1, 1001, 100, 1, 100, 1008, 100, 16, 101, 1006, 101, 0, 99 };
            long[] test02 = { 1102, 34915192, 34915192, 7, 4, 7, 99, 0 };
            long[] test03 = { 104, 1125899906842624, 99 };
            long[] boost = { 1102, 34463338, 34463338, 63, 1007, 63, 34463338, 63, 1005, 63, 53, 1102, 1, 3, 1000, 109, 988, 209, 12, 9, 1000, 209, 6, 209, 3, 203, 0, 1008, 1000, 1, 63, 1005, 63, 65, 1008, 1000, 2, 63, 1005, 63, 904, 1008, 1000, 0, 63, 1005, 63, 58, 4, 25, 104, 0, 99, 4, 0, 104, 0, 99, 4, 17, 104, 0, 99, 0, 0, 1101, 39, 0, 1004, 1101, 0, 37, 1013, 1101, 0, 28, 1001, 1101, 0, 38, 1005, 1101, 23, 0, 1008, 1102, 1, 0, 1020, 1102, 1, 26, 1010, 1102, 31, 1, 1009, 1101, 29, 0, 1015, 1102, 459, 1, 1024, 1101, 33, 0, 1007, 1101, 0, 30, 1016, 1101, 32, 0, 1002, 1102, 1, 494, 1027, 1101, 0, 216, 1029, 1101, 497, 0, 1026, 1101, 0, 303, 1022, 1102, 1, 21, 1018, 1102, 1, 36, 1006, 1102, 1, 27, 1014, 1102, 296, 1, 1023, 1102, 454, 1, 1025, 1102, 35, 1, 1003, 1101, 22, 0, 1017, 1102, 225, 1, 1028, 1102, 1, 20, 1011, 1101, 1, 0, 1021, 1101, 0, 24, 1000, 1101, 0, 25, 1019, 1101, 0, 34, 1012, 109, 13, 21102, 40, 1, 0, 1008, 1013, 40, 63, 1005, 63, 203, 4, 187, 1106, 0, 207, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 5, 2106, 0, 10, 4, 213, 1001, 64, 1, 64, 1105, 1, 225, 1002, 64, 2, 64, 109, -3, 1206, 6, 241, 1001, 64, 1, 64, 1105, 1, 243, 4, 231, 1002, 64, 2, 64, 109, -17, 2108, 30, 4, 63, 1005, 63, 259, 1106, 0, 265, 4, 249, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 14, 2108, 35, -9, 63, 1005, 63, 283, 4, 271, 1105, 1, 287, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 13, 2105, 1, -2, 1001, 64, 1, 64, 1106, 0, 305, 4, 293, 1002, 64, 2, 64, 109, -28, 1208, 5, 32, 63, 1005, 63, 327, 4, 311, 1001, 64, 1, 64, 1106, 0, 327, 1002, 64, 2, 64, 109, 12, 2102, 1, 0, 63, 1008, 63, 31, 63, 1005, 63, 353, 4, 333, 1001, 64, 1, 64, 1105, 1, 353, 1002, 64, 2, 64, 109, 7, 21102, 41, 1, -6, 1008, 1010, 40, 63, 1005, 63, 373, 1105, 1, 379, 4, 359, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -4, 2102, 1, -6, 63, 1008, 63, 35, 63, 1005, 63, 403, 1001, 64, 1, 64, 1105, 1, 405, 4, 385, 1002, 64, 2, 64, 109, 11, 21107, 42, 43, -4, 1005, 1019, 427, 4, 411, 1001, 64, 1, 64, 1105, 1, 427, 1002, 64, 2, 64, 109, -10, 1206, 7, 445, 4, 433, 1001, 64, 1, 64, 1105, 1, 445, 1002, 64, 2, 64, 109, 10, 2105, 1, 1, 4, 451, 1105, 1, 463, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -14, 21108, 43, 42, 4, 1005, 1013, 479, 1106, 0, 485, 4, 469, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 12, 2106, 0, 6, 1106, 0, 503, 4, 491, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -10, 2107, 30, -2, 63, 1005, 63, 521, 4, 509, 1106, 0, 525, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -7, 2101, 0, -4, 63, 1008, 63, 26, 63, 1005, 63, 549, 1001, 64, 1, 64, 1106, 0, 551, 4, 531, 1002, 64, 2, 64, 109, 13, 21107, 44, 43, -3, 1005, 1014, 571, 1001, 64, 1, 64, 1105, 1, 573, 4, 557, 1002, 64, 2, 64, 109, -6, 21108, 45, 45, 1, 1005, 1012, 591, 4, 579, 1106, 0, 595, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 8, 1205, 2, 609, 4, 601, 1106, 0, 613, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -11, 1208, -6, 34, 63, 1005, 63, 629, 1106, 0, 635, 4, 619, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -15, 2107, 33, 9, 63, 1005, 63, 651, 1106, 0, 657, 4, 641, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 9, 1207, 2, 38, 63, 1005, 63, 677, 1001, 64, 1, 64, 1106, 0, 679, 4, 663, 1002, 64, 2, 64, 109, 8, 21101, 46, 0, 0, 1008, 1010, 45, 63, 1005, 63, 703, 1001, 64, 1, 64, 1106, 0, 705, 4, 685, 1002, 64, 2, 64, 109, -5, 1201, -3, 0, 63, 1008, 63, 32, 63, 1005, 63, 727, 4, 711, 1106, 0, 731, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -6, 1207, 8, 34, 63, 1005, 63, 753, 4, 737, 1001, 64, 1, 64, 1106, 0, 753, 1002, 64, 2, 64, 109, 29, 1205, -8, 765, 1106, 0, 771, 4, 759, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -18, 1202, -6, 1, 63, 1008, 63, 39, 63, 1005, 63, 797, 4, 777, 1001, 64, 1, 64, 1106, 0, 797, 1002, 64, 2, 64, 109, 8, 21101, 47, 0, 0, 1008, 1018, 47, 63, 1005, 63, 823, 4, 803, 1001, 64, 1, 64, 1105, 1, 823, 1002, 64, 2, 64, 109, -12, 2101, 0, -3, 63, 1008, 63, 35, 63, 1005, 63, 845, 4, 829, 1106, 0, 849, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, -9, 1201, 5, 0, 63, 1008, 63, 30, 63, 1005, 63, 869, 1105, 1, 875, 4, 855, 1001, 64, 1, 64, 1002, 64, 2, 64, 109, 8, 1202, -2, 1, 63, 1008, 63, 34, 63, 1005, 63, 899, 1001, 64, 1, 64, 1105, 1, 901, 4, 881, 4, 64, 99, 21101, 27, 0, 1, 21101, 0, 915, 0, 1105, 1, 922, 21201, 1, 45467, 1, 204, 1, 99, 109, 3, 1207, -2, 3, 63, 1005, 63, 964, 21201, -2, -1, 1, 21101, 942, 0, 0, 1106, 0, 922, 21201, 1, 0, -1, 21201, -2, -3, 1, 21102, 1, 957, 0, 1105, 1, 922, 22201, 1, -1, -2, 1105, 1, 968, 22101, 0, -2, -2, 109, -3, 2106, 0, 0 };

            Part1(test01, new Queue<long>());
            Part1(test02, new Queue<long>());
            Part1(test03, new Queue<long>());

            Part1(boost, new Queue<long>() { 1 });

            // Part 2
            Part1(boost, new Queue<long>() { 2 });
        }

        static void Part1(long[] p, Queue<long> input)
        {
            var vm = new IntVM(p, input);
            vm.Run();
            var result = string.Join(",", vm.Output);
            Console.WriteLine($"> {result}");
        }
    }

    class IntVM
    {
        private long[] memory = new long[1_000_000];
        long pc = 0;
        long rel = 0;

        public IntVM(long[] program, Queue<long> input)
        {
            //memory = (long[])program.Clone();
            Array.Copy(program, 0, memory, 0, program.Length);
            pc = 0;
            Input = input;
            Output = new Queue<long>();
        }

        public Queue<long> Input { get; private set; }
        public Queue<long> Output { get; private set; }

        public bool debug { get; set; } = false;

        // Run until empty input or done.
        // Return true when done (opcode = 99) false when waiting on input.
        public bool Run()
        {
            do
            {
                var opCode = memory[pc] % 100;
                var pmode = new long[3];
                pmode[0] = memory[pc] / 100 % 10;
                pmode[1] = memory[pc] / 1000 % 10;
                pmode[2] = memory[pc] / 10000 % 10;
                if (debug) System.Console.Write($"{pc}\t{opCode}\t{string.Join(',', pmode)}\t");
                switch (opCode)
                {
                    case 1: // add a1 + b1 
                        var a1 = memory[addr(pmode[0], pc + 1)]; // pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b1 = memory[addr(pmode[1], pc + 2)]; // pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        var dest1 = addr(pmode[2], pc + 3); //memory[pc + 3];
                        if (debug) Console.Write($"{a1} + {b1} in r:{dest1}");
                        memory[dest1] = a1 + b1;
                        pc = pc + 4;
                        break;
                    case 2: // mult a2 * b2
                        var a2 = memory[addr(pmode[0], pc + 1)]; // pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b2 = memory[addr(pmode[1], pc + 2)]; // pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        var dest2 = addr(pmode[2], pc + 3);
                        if (debug) Console.Write($"{a2} * {b2} in r:{dest2}");
                        memory[dest2] = a2 * b2;
                        pc = pc + 4;
                        break;
                    case 3: //read
                        if (Input.Count == 0)
                            return false; // not done, waiting for input.
                        var dest3 = addr(pmode[0], pc + 1);
                        if (debug) Console.Write($"input in {dest3}");
                        memory[dest3] = Input.Dequeue();
                        pc = pc + 2;
                        break;
                    case 4: // write
                        long dest4 = addr(pmode[0], pc + 1);
                        if (debug) Console.Write($"write from {dest4}");
                        if (debug) Console.Write($"\t>> {memory[dest4]} <<");
                        Output.Add(memory[dest4]);
                        pc = pc + 2;
                        break;
                    case 5: // jump if not zero/true
                        var a5 = memory[addr(pmode[0], pc + 1)]; // pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b5 = memory[addr(pmode[1], pc + 2)]; // pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        if (debug) Console.Write($"if {a5} != 0 goto {b5}");
                        if (a5 != 0)
                            pc = b5;
                        else
                            pc += 3;
                        break;
                    case 6: // jump if zero/false
                        var a6 = memory[addr(pmode[0], pc + 1)]; // pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b6 = memory[addr(pmode[1], pc + 2)]; // pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        if (debug) Console.Write($"if {a6} == 0 goto {b6}");
                        if (a6 == 0)
                            pc = b6;
                        else
                            pc += 3;
                        break;
                    case 7: // less than
                        var a7 = memory[addr(pmode[0], pc + 1)]; // pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b7 = memory[addr(pmode[1], pc + 2)]; // pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        var dest7 = addr(pmode[2], pc + 3);
                        if (debug) Console.Write($"if {a7} < {b7} then {dest7} = 1 else 0");
                        memory[dest7] = a7 < b7 ? 1 : 0;
                        pc = pc + 4;
                        break;
                    case 8: // eqauls
                        var a8 = memory[addr(pmode[0], pc + 1)]; // pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b8 = memory[addr(pmode[1], pc + 2)]; // pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        var dest8 = addr(pmode[2], pc + 3);
                        if (debug) Console.Write($"if {a8} == {b8} then {dest8} = 1 else 0");
                        memory[dest8] = a8 == b8 ? 1 : 0;
                        pc = pc + 4;
                        break;
                    case 9: // set rel
                        var a9 = memory[addr(pmode[0], pc + 1)];
                        rel = rel + a9;
                        pc = pc + 2;
                        break;
                    case 99:
                        if (debug) Console.WriteLine("DONE");
                        if (debug) Console.WriteLine("");
                        return true;
                }
                if (debug) Console.WriteLine();

            } while (true);
        }

        private long addr(long mode, long i)
        {
            switch(mode){
                case 0: return memory[i]; // position mode
                case 1: return i;         // Direct mode
                case 2: return memory[i] + rel; // Relative mode
                default: throw new NotSupportedException();
            }
        }

    }

    public static class Extensions
    {
        public static Stack<T> Add<T>(this Stack<T> s, T value)
        {
            s.Push(value);
            return s;
        }

        public static Queue<T> Add<T>(this Queue<T> q, T value)
        {
            q.Enqueue(value);
            return q;
        }

        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(this IEnumerable<T> list)
        {
            return GetPermutations(list, list.Count());
        }

        static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}
