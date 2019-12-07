using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var test01 = new int[] { 3, 15, 3, 16, 1002, 16, 10, 16, 1, 16, 15, 15, 4, 15, 99, 0, 0 };
            var test02 = new int[] { 3, 23, 3, 24, 1002, 24, 10, 24, 1002, 23, -1, 23, 101, 5, 23, 23, 1, 24, 23, 23, 4, 23, 99, 0, 0 };
            var test03 = new int[] { 3, 31, 3, 32, 1002, 32, 10, 32, 1001, 31, -2, 31, 1007, 31, 0, 33, 1002, 33, 7, 33, 1, 33, 31, 31, 1, 32, 31, 31, 4, 31, 99, 0, 0, 0 };
            var input = new int[] { 3, 8, 1001, 8, 10, 8, 105, 1, 0, 0, 21, 38, 47, 72, 97, 122, 203, 284, 365, 446, 99999, 3, 9, 1001, 9, 3, 9, 1002, 9, 5, 9, 1001, 9, 4, 9, 4, 9, 99, 3, 9, 102, 3, 9, 9, 4, 9, 99, 3, 9, 1001, 9, 2, 9, 102, 5, 9, 9, 101, 3, 9, 9, 1002, 9, 5, 9, 101, 4, 9, 9, 4, 9, 99, 3, 9, 101, 5, 9, 9, 1002, 9, 3, 9, 101, 2, 9, 9, 102, 3, 9, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 101, 3, 9, 9, 102, 2, 9, 9, 1001, 9, 4, 9, 1002, 9, 2, 9, 101, 2, 9, 9, 4, 9, 99, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 99, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 99, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 99, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 1, 9, 4, 9, 99, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 102, 2, 9, 9, 4, 9, 3, 9, 101, 1, 9, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 1002, 9, 2, 9, 4, 9, 3, 9, 101, 2, 9, 9, 4, 9, 3, 9, 1001, 9, 2, 9, 4, 9, 99 };

            var test11 = new int[] { 3, 26, 1001, 26, -4, 26, 3, 27, 1002, 27, 2, 27, 1, 27, 26, 27, 4, 27, 1001, 28, -1, 28, 1005, 28, 6, 99, 0, 0, 5 };
            var test12 = new int[] { 3, 52, 1001, 52, -5, 52, 3, 53, 1, 52, 56, 54, 1007, 54, 5, 55, 1005, 55, 26, 1001, 54, -5, 54, 1105, 1, 12, 1, 53, 54, 53, 1008, 54, 0, 55, 1001, 55, 1, 55, 2, 53, 55, 53, 4, 53, 1001, 56, -1, 56, 1005, 56, 6, 99, 0, 0, 0, 0, 10 };

            var s = new Solver();

            s.Part1(test01);
            s.Part1(test02);
            s.Part1(test03);

            s.Part1(input);

            s.Part2(test11);
            s.Part2(test12);

            s.Part2(input);
        }
    }

    class Solver
    {
        public void Part1(int[] prog)
        {
            var max = int.MinValue;
            var phases = Enumerable.Range(0, 5).GetPermutations();
            foreach(var phase in phases){
                //Console.WriteLine("Trying phase: "+string.Join(", ", phase));
                var result = Part1(prog, phase.ToArray(), 0);
                max = Math.Max(result, max);
            }
            Console.WriteLine($"Max Part1: {max}");

        }

        public int Part1(int[] prog, int[] phase, int init)
        {
            var vmA = new IntVM(prog, new Queue<int> { phase[0], init });
            var vmB = new IntVM(prog, new Queue<int> { phase[1] });
            var vmC = new IntVM(prog, new Queue<int> { phase[2] });
            var vmD = new IntVM(prog, new Queue<int> { phase[3] });
            var vmE = new IntVM(prog, new Queue<int> { phase[4] });

            var a = vmA.Run();
            vmB.Input.Enqueue(vmA.Output.Dequeue());
            var b = vmB.Run();
            vmC.Input.Enqueue(vmB.Output.Dequeue());
            var c = vmC.Run();
            vmD.Input.Enqueue(vmC.Output.Dequeue());
            var d = vmD.Run();
            vmE.Input.Enqueue(vmD.Output.Dequeue());
            var e = vmE.Run();

            //Console.WriteLine("Part1: " + e);
            return vmE.Output.Dequeue();
        }


        public void Part2(int[] prog)
        {
            var max = int.MinValue;
            var phases = Enumerable.Range(5, 5).GetPermutations();
            foreach (var phase in phases)
            {
                //Console.WriteLine("Trying phase: "+string.Join(", ", phase));
                var result = Part2(prog, phase.ToArray(), 0);
                max = Math.Max(result, max);
            }
            Console.WriteLine($"Max Part2: {max}");

        }

        public int Part2(int[] prog, int[] phase, int init)
        {

            var vmA = new IntVM(prog, new Queue<int> { phase[0], init });
            var vmB = new IntVM(prog, new Queue<int> { phase[1] });
            var vmC = new IntVM(prog, new Queue<int> { phase[2] });
            var vmD = new IntVM(prog, new Queue<int> { phase[3] });
            var vmE = new IntVM(prog, new Queue<int> { phase[4] });

            bool feedback = true;
            do
            {
                var a = vmA.Run();
                vmB.Input.Enqueue(vmA.Output.Dequeue());
                var b = vmB.Run();
                vmC.Input.Enqueue(vmB.Output.Dequeue());
                var c = vmC.Run();
                vmD.Input.Enqueue(vmC.Output.Dequeue());
                var d = vmD.Run();
                vmE.Input.Enqueue(vmD.Output.Dequeue());
                var e = vmE.Run();
                if (e) // done
                {
                    feedback = false;
                }
                else
                {
                    vmA.Input.Enqueue(vmE.Output.Dequeue());
                }
            } while (feedback);

            return vmE.Output.Dequeue();
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

    class IntVM
    {
        private int[] memory;
        int pc = 0;

        public IntVM(int[] program, Queue<int> input)
        {
            memory = (int[])program.Clone();
            pc = 0;
            Input = input;
            Output = new Queue<int>();
        }

        public Queue<int> Input { get; private set; }
        public Queue<int> Output { get; private set; }

        public bool debug { get; set; } = false;

        // Run until empty input or done.
        // Return true when done (opcode = 99) false when waiting on input.
        public bool Run()
        {
            do
            {
                var opCode = memory[pc] % 100;
                var pmode = new bool[3];
                pmode[0] = memory[pc] / 100 % 10 == 0;
                pmode[1] = memory[pc] / 1000 % 10 == 0;
                pmode[2] = memory[pc] / 10000 % 10 == 0;
                if (debug) System.Console.Write($"{pc}\t{opCode}\t{string.Join(',', pmode)}\t");
                switch (opCode)
                {
                    case 1: // add a1 + b1 
                        var a1 = pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b1 = pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        var dest1 = memory[pc + 3];
                        if (debug) Console.Write($"{a1} + {b1} in r:{dest1}");
                        memory[dest1] = a1 + b1;
                        pc = pc + 4;
                        break;
                    case 2: // mult a2 * b2
                        var a2 = pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b2 = pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        var dest2 = memory[pc + 3];
                        if (debug) Console.Write($"{a2} * {b2} in r:{dest2}");
                        memory[dest2] = a2 * b2;
                        pc = pc + 4;
                        break;
                    case 3: //read
                        if (Input.Count == 0)
                            return false; // not done, waiting for input.
                        var dest3 = memory[pc + 1];
                        if (debug) Console.Write($"input in {dest3}");
                        memory[dest3] = Input.Dequeue();
                        pc = pc + 2;
                        break;
                    case 4: // write
                        int dest4;
                        if (pmode[0])
                            dest4 = memory[pc + 1];
                        else
                            dest4 = pc + 1;
                        if (debug) Console.Write($"write from {dest4}");
                        if (debug) Console.Write($"\t>> {memory[dest4]} <<");
                        Output.Add( memory[dest4]);
                        pc = pc + 2;
                        break;
                    case 5: // jump if not zero/true
                        var a5 = pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b5 = pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        if (debug) Console.Write($"if {a5} != 0 goto {b5}");
                        if (a5 != 0)
                            pc = b5;
                        else
                            pc += 3;
                        break;
                    case 6: // jump if zero/false
                        var a6 = pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b6 = pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        if (debug) Console.Write($"if {a6} == 0 goto {b6}");
                        if (a6 == 0)
                            pc = b6;
                        else
                            pc += 3;
                        break;
                    case 7: // less than
                        var a7 = pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b7 = pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        var dest7 = memory[pc + 3];
                        if (debug) Console.Write($"if {a7} < {b7} then {dest7} = 1 else 0");
                        memory[dest7] = a7 < b7 ? 1 : 0;
                        pc = pc + 4;
                        break;
                    case 8: // eqauls
                        var a8 = pmode[0] ? memory[memory[pc + 1]] : memory[pc + 1];
                        var b8 = pmode[1] ? memory[memory[pc + 2]] : memory[pc + 2];
                        var dest8 = memory[pc + 3];
                        if (debug) Console.Write($"if {a8} == {b8} then {dest8} = 1 else 0");
                        memory[dest8] = a8 == b8 ? 1 : 0;
                        pc = pc + 4;
                        break;
                    case 99:
                        if (debug) Console.WriteLine("DONE");
                        if (debug) Console.WriteLine("");
                        return true;
                }
                if (debug) Console.WriteLine();

            } while (true);

        }

    }
}
