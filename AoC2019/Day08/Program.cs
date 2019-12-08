using System;
using System.Collections.Generic;
using System.Linq;

namespace Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solver();
            //s.Part1(Input.Test, w:3, h:2, check: 1);
            s.Part1(Input.Data, w: 25, h: 6, check: 0);
        }
    }


    class Solver
    {
        public void Part1(string data, int w, int h, int check = 0)
        {
            int layer_size = w * h;
            int layer_count = data.Length / (layer_size);
           
            List<string> layers = new List<string>();
            for(int i = 0; i < layer_count; i++)
            {
                layers.Add(data.Substring(i*layer_size, layer_size));
            }

            List<Dictionary<int, int>> hist = layers.Select(x => x.GroupBy(c => c).ToDictionary(g => (int)(g.Key-'0'), g => g.Count())).ToList();

            // Part 1
            var least_zero = hist.OrderBy(x => x[check]).First();
            var checksum = least_zero[1] * least_zero[2];
            Console.WriteLine("Part1: " + checksum);

            // Part2
            layers.Reverse();
            int offset_w = 1;
            int offset_h = 1;
            foreach (var layer in layers)
            {
                Console.SetCursorPosition(offset_w, offset_h);
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        Console.SetCursorPosition(j + offset_w, i+ offset_h);
                        var color = layer[w * i + j];
                        switch (color)
                        {
                            case '0':
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.Write("X");
                                break;
                            case '1':
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("X");
                                break;
                            case '2':
                                // transparent, do nothing.
                                break;
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
