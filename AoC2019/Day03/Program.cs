﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var s = new Solver();

            Console.WriteLine($"Test: " + s.Part1("R8,U5,L5,D3", "U7,R6,D4,L4"));

            Console.WriteLine($"Test: " + s.Part1("R75,D30,R83,U83,L12,D49,R71,U7,L72", "U62,R66,U55,R34,D71,R55,D58,R83"));

            Console.WriteLine($"Test: " + s.Part1("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51", "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7"));

            Console.WriteLine($"Part 1: " + s.Part1(inputA, inputB));

            Console.ReadLine();
        }

        const string inputA = "R990,U944,L921,U993,L64,U29,R899,D406,R841,U716,L32,U658,L830,D481,L441,U491,L687,D847,L459,U920,R165,U224,L896,D868,L191,U877,L909,U467,R798,U132,R234,U49,R484,U911,R108,D308,R867,U350,L404,U107,L84,U668,R850,U470,L182,U93,R284,U999,L664,U110,R650,D189,R540,D112,R794,U999,R871,D829,L549,U988,R654,D411,R323,D774,R529,U275,L909,U936,R122,D922,L331,U813,L748,U770,R511,D892,L770,U318,R661,U823,R210,D393,L694,U929,L76,D619,R395,U651,R526,U145,R851,U112,R73,D89,R17,U929,R807,U87,R764,D158,L820,U803,L785,D205,L828,D271,L839,D482,L797,U338,R322,D633,L292,U16,R627,U19,R548,U516,L384,U83,R256,U937,R404,U322,R671,D543,L412,U446,R238,U246,L794,D750,L34,U317,L994,U874,L247,D20,R491,U834,L498,D987,R2,U175,R452,U168,R495,D183,R201,U532,L192,U984,L566,D471,L704,D2,L776,U5,R911,U308,R763,D555,R458,D439,L968,D78,R549,D583,R289,D355,L503,D871,L881,U516,L507,D551,R711,U702,L308,D905,L408,U932,L884,U218,L158,D562,L200,D114,R673,U448,R887,U181,R247,U329,L965,U495,L329,D162,L265,D389,R419,U435,R258,U146,R208,D184,R730,D19,L78,D886,R472,D350,R484,U392,L542,U601,L202,U974,L310,U52,L537,U597,L163,D655,R928,U269,L926,D790,L513,U441,L90,U581,L211,U871,R603,D130,L220,U459,L933,U648,R721,U642,R301,U537,L858,D777,R823,U14,R820,D218,L96,D318,L206,U280,R887,D241,L752,U828,R354,U864,R844,D872,L728,D298,L234,U695,R434,D94,R905,D592,L32,D860,R680,D197,R886,U760,L232,U916,L452,U248,R715,D773,R867,U77,R751,D36,R565,U897,R782,U931,R546,U261,R920,D296,R451,U258,L394,U965,R912,D593,L990";
        const string inputB = "L994,U515,R163,U863,L343,U162,L875,D92,L483,D601,R79,D761,L389,U167,L145,U145,L247,U886,R61,U820,L584,D239,R402,U805,R956,U126,R615,D322,R431,D460,R397,D511,R805,D177,L778,U296,R599,U759,R40,U1,L422,U751,R94,U401,R504,U940,L564,U24,R595,U944,R815,U672,R787,D854,R579,D604,L62,U670,L516,U199,L639,D919,L485,U655,R391,U669,R772,D34,R868,D12,L108,U295,R701,D603,R493,U927,R29,D34,R499,U111,L87,U190,R884,D658,R474,D166,R921,U698,R592,U25,R710,D398,L26,U696,L432,D887,R469,U656,L428,D188,L543,D150,R160,U543,R743,U692,R618,D148,R956,U753,L175,D789,R897,U305,L137,D914,R330,D780,R744,D473,L754,U482,L975,D413,L698,U656,L177,U419,R13,D827,L67,D800,R369,U97,L34,D588,L41,D760,L164,U224,L921,D311,R489,U956,R277,U180,R724,U748,R785,U826,L426,D957,R303,U16,L729,U224,L712,U43,L280,D648,R987,D941,R154,D581,R876,U615,L480,D103,R636,D276,R948,U89,R434,D212,R837,D295,R532,D390,R374,D926,R911,D110,R258,U83,L955,U747,L925,D366,R571,U241,R628,D344,R919,U117,R337,D683,L720,U261,L124,D545,R979,D601,L906,D324,R441,U678,L978,U744,L472,D217,R799,U740,L77,U964,L278,U497,R441,U21,L37,U319,L24,D211,L44,U459,R35,D609,R900,D538,R397,D776,R629,D860,R519,D340,R168,U603,R46,U889,R897,D442,R997,U705,L82,D963,R941,U701,L347,D824,R269,U891,L569,D558,L867,U145,R121,D369,R542,U227,L198,U863,L755,U273,L734,D233,R578,U67,L821,U600,L203,D234,R695,U819,L639,D700,R295,D129,L612,U157,R212,U536,L968,U562,L999,D391,L231,U262,R334,D967,R463,U748,R842,D500,R860,U856,R263,D633,R460,D337,L880,U146,R910";
    }

    class Solver
    {
        public int Part1(string pathA, string pathB)
        {
            var gridA = drawPath(pathA);
            var gridB = drawPath(pathB);

            var cross = gridA.Join(gridB, a => a.Key, b => b.Key, (a, b) => (a.Key, a.Value+b.Value));

            var dist = cross.Select(p => Math.Abs(p.Key.x) + Math.Abs(p.Key.y)).OrderBy(x => x);
            Console.WriteLine("Cross distances:");
            //foreach(var d in dist)
            //{
            //    Console.WriteLine($"{d}");
            //}
            Console.WriteLine(dist.Where(d => d > 0).First());

            Console.WriteLine("Cross steps:");
            var step_d = cross.Select(p => p.Item2).OrderBy(x => x);
            //foreach (var d in step_d)
            //{
            //    Console.WriteLine($"{d}");
            //}
            Console.WriteLine(step_d.Where(d => d > 0).First());

            //return dist.Where(d => d > 0).First(); // Part 1
            return step_d.Where(d => d > 0).First(); // Part 2
        }

        private Dictionary<(int x,int y), int> drawPath(string path)
        {
            var grid = new Dictionary<(int x, int y), int>();
            var x = 0;
            var y = 0;
            var steps = path.Split(',');
            var step_count = 0;
            foreach(var step in steps)
            {
                var dx = 0;
                var dy = 0;
                var cnt = int.Parse(step.Substring(1));
                switch(step[0]){
                    case 'D':
                        dy = -1; break;
                    case 'U':
                        dy = 1; break;
                    case 'L':
                        dx = 1; break;
                    case 'R':
                        dx = -1; break;
                    default:
                        throw new Exception("strange direction");
                }
                for(int i = 0; i < cnt; i++)
                {
                    x += dx;
                    y += dy;
                    step_count++;
                    if (!grid.ContainsKey((x, y)))
                        grid.Add((x, y), step_count);
                }
            }
            return grid;
        }
    }
}
