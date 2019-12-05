using System;
using System.Linq;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var vm = new IntVM();

            var test01 = new int[] { 1002, 4, 3, 4, 33 };

            //Console.WriteLine("Test01: "+ vm.Run(test01, 1));
            //Console.WriteLine("Part01: " + vm.Run(vm.input, 1));

            var test02_p_eq8 = new int[] { 3, 9, 8, 9, 10, 9, 4, 9, 99, -1, 8 };
            var test02_p_lt8 = new int[] { 3, 9, 7, 9, 10, 9, 4, 9, 99, -1, 8 };
            var test02_i_eq8 = new int[] { 3, 3, 1108, -1, 8, 3, 4, 3, 99 };
            var test02_i_lt8 = new int[] { 3, 3, 1107, -1, 8, 3, 4, 3, 99 };
            var test02_p_eq0 = new int[] { 3, 12, 6, 12, 15, 1, 13, 14, 13, 4, 13, 99, -1, 0, 1, 9 }; // jump test
            var test02_i_eq0 = new int[] { 3, 3, 1105, -1, 9, 1101, 0, 0, 12, 4, 12, 99, 1 }; // jump test
            var test02_test8 = new int[] { 3,21,1008,21,8,20,1005,20,22,107,8,21,20,1006,20,31,
                                            1106,0,36,98,0,0,1002,21,125,20,4,20,1105,1,46,104,
                                            999,1105,1,46,1101,1000,1,20,4,20,1105,1,46,98,99}; // large
            //Console.WriteLine("Test p eq 8");
            //vm.Run(test02_p_eq8, 7);
            //vm.Run(test02_p_eq8, 8);
            //vm.Run(test02_p_eq8, 9);

            //Console.WriteLine("Test p lt 8");
            //vm.Run(test02_p_lt8, 7);
            //vm.Run(test02_p_lt8, 8);
            //vm.Run(test02_p_lt8, 9);

            //Console.WriteLine("Test i eq 8");
            //vm.Run(test02_i_eq8, 7);
            //vm.Run(test02_i_eq8, 8);
            //vm.Run(test02_i_eq8, 9);

            //Console.WriteLine("Test i lt 8");
            //vm.Run(test02_i_lt8, 7);
            //vm.Run(test02_i_lt8, 8);
            //vm.Run(test02_i_lt8, 9);

            //Console.WriteLine("Test p eq0");
            //vm.Run(test02_p_eq0, -1);
            //vm.Run(test02_p_eq0, 0);
            //vm.Run(test02_p_eq0, 1);

            //Console.WriteLine("Test i eq0");
            //vm.Run(test02_i_eq0, -1);
            //vm.Run(test02_i_eq0, 0);
            //vm.Run(test02_i_eq0, 1);

            //Console.WriteLine("Test 8");
            //vm.Run(test02_test8, 7);
            //vm.Run(test02_test8, 8);
            //vm.Run(test02_test8, 9);

            Console.WriteLine("Part2:");
            vm.Run(vm.input, 5);

        }
    }

    class IntVM
    {
        public bool debug { get; set; } = false;

        public int Run(int[] program, int input)
        {
            int[] memory = (int[])program.Clone();

            int pc = 0;
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
                        memory[dest1] =  a1 + b1;
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
                        var dest3 = memory[pc + 1];
                        if (debug) Console.Write($"input in {dest3}");
                        memory[dest3] = input;
                        pc = pc + 2;
                        break;
                    case 4: // write
                        int dest4;
                        if (pmode[0])
                            dest4 = memory[pc + 1];
                        else
                            dest4 = pc + 1;
                        if (debug) Console.Write($"write from {dest4}");
                        Console.Write($"\t>> {memory[dest4]} <<");
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
                        Console.WriteLine("DONE");
                        if (debug) Console.WriteLine("");
                        return memory[0];
                }
                if (debug) Console.WriteLine();
                
            } while (true);

        }

        public int[] input = new int[] { 3, 225, 1, 225, 6, 6, 1100, 1, 238, 225, 104, 0, 101, 14, 135, 224, 101, -69, 224, 224, 4, 224, 1002, 223, 8, 223, 101, 3, 224, 224, 1, 224, 223, 223, 102, 90, 169, 224, 1001, 224, -4590, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 1, 224, 1, 224, 223, 223, 1102, 90, 45, 224, 1001, 224, -4050, 224, 4, 224, 102, 8, 223, 223, 101, 5, 224, 224, 1, 224, 223, 223, 1001, 144, 32, 224, 101, -72, 224, 224, 4, 224, 102, 8, 223, 223, 101, 3, 224, 224, 1, 223, 224, 223, 1102, 36, 93, 225, 1101, 88, 52, 225, 1002, 102, 38, 224, 101, -3534, 224, 224, 4, 224, 102, 8, 223, 223, 101, 4, 224, 224, 1, 223, 224, 223, 1102, 15, 57, 225, 1102, 55, 49, 225, 1102, 11, 33, 225, 1101, 56, 40, 225, 1, 131, 105, 224, 101, -103, 224, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 2, 224, 1, 224, 223, 223, 1102, 51, 39, 225, 1101, 45, 90, 225, 2, 173, 139, 224, 101, -495, 224, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 5, 224, 1, 223, 224, 223, 1101, 68, 86, 224, 1001, 224, -154, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 1, 224, 1, 224, 223, 223, 4, 223, 99, 0, 0, 0, 677, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1105, 0, 99999, 1105, 227, 247, 1105, 1, 99999, 1005, 227, 99999, 1005, 0, 256, 1105, 1, 99999, 1106, 227, 99999, 1106, 0, 265, 1105, 1, 99999, 1006, 0, 99999, 1006, 227, 274, 1105, 1, 99999, 1105, 1, 280, 1105, 1, 99999, 1, 225, 225, 225, 1101, 294, 0, 0, 105, 1, 0, 1105, 1, 99999, 1106, 0, 300, 1105, 1, 99999, 1, 225, 225, 225, 1101, 314, 0, 0, 106, 0, 0, 1105, 1, 99999, 108, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 329, 1001, 223, 1, 223, 1007, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 344, 101, 1, 223, 223, 1008, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 359, 1001, 223, 1, 223, 107, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 374, 101, 1, 223, 223, 1107, 677, 226, 224, 102, 2, 223, 223, 1006, 224, 389, 101, 1, 223, 223, 108, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 404, 1001, 223, 1, 223, 1108, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 419, 101, 1, 223, 223, 1007, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 434, 101, 1, 223, 223, 1107, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 449, 101, 1, 223, 223, 8, 677, 226, 224, 102, 2, 223, 223, 1006, 224, 464, 1001, 223, 1, 223, 1107, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 479, 1001, 223, 1, 223, 1007, 677, 677, 224, 102, 2, 223, 223, 1005, 224, 494, 1001, 223, 1, 223, 1108, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 509, 101, 1, 223, 223, 1008, 677, 677, 224, 102, 2, 223, 223, 1005, 224, 524, 1001, 223, 1, 223, 107, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 539, 101, 1, 223, 223, 7, 226, 226, 224, 102, 2, 223, 223, 1005, 224, 554, 101, 1, 223, 223, 1108, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 569, 1001, 223, 1, 223, 107, 677, 677, 224, 102, 2, 223, 223, 1005, 224, 584, 101, 1, 223, 223, 7, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 599, 101, 1, 223, 223, 108, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 614, 101, 1, 223, 223, 1008, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 629, 1001, 223, 1, 223, 7, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 644, 101, 1, 223, 223, 8, 677, 677, 224, 102, 2, 223, 223, 1005, 224, 659, 1001, 223, 1, 223, 8, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 674, 1001, 223, 1, 223, 4, 223, 99, 226 };
    }
}
