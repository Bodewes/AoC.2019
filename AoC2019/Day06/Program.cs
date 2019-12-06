using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var s = new Solver();
            //s.Load(Input.test);
            s.Load(Input.data);
            s.CountOrbits();
            s.Print();
            s.FindCommonParent("YOU", "SAN");
            //s.FindCommonParent("L", "I");

        }
    }

    class Solver
    {
        List<Planet> planets = new List<Planet>();
        Planet root;

        public void Load(string data)
        {
            var lines = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            foreach(var line in lines)
            {
                var r = line.Split(")");
                var a = r[0];
                var b = r[1]; // b orbits a, b is a moon of a.

                var planet = FindOrAdd(a);
                var moon = FindOrAdd(b);

                planet.AddMoon(moon);
            }

            root = planets.Single(p => p.Parent == null);
        }

        private Planet FindOrAdd(string name)
        {
            var planet = planets.FirstOrDefault(p => p.Name == name);
            if (planet == null)
            {
                planet = new Planet() { Name = name };
                planets.Add(planet);
            }
            return planet;
        }

        public void Print()
        {
            Print(root, "");
        }
        private void Print(Planet p, string indent)
        {
            Console.WriteLine(indent + p.Name +$"({p.Depth})");
            foreach (var m in p.Moons)
                Print(m, indent + "  ");
        }

        public void CountOrbits()
        {
            Console.WriteLine("Total Orbits: "+this.CountOrbits(root, 0));
        }

        private int CountOrbits(Planet p, int c)
        {
            p.Depth = c;
            return c + p.Moons.Sum(x => CountOrbits(x, c + 1));
        }

        public void FindCommonParent(string a, string b)
        {

            var pa = planets.Single(p => p.Name == a);
            var pb = planets.Single(p => p.Name == b);
            FindCommonParent(pa, pb, 0);
        }

        private void FindCommonParent(Planet a, Planet b, int steps)
        {
            // Done?
            if (a.Parent == b.Parent)
            {
                Console.WriteLine($"Steps: {steps}");
                return;
            }

            if (a.Depth < b.Depth)
            {
                FindCommonParent(a, b.Parent, steps + 1);
            }
            else //if (a.Depth > b.Depth) // en gelijk
            {
                FindCommonParent(a.Parent, b, steps + 1);
            }

        }
    }

    public class Planet
    {


        public string Name { get; set; }
        public Planet Parent { get; set; } = null;

        public List<Planet> Moons { get; } = new List<Planet>();

        public int Depth { get; set; } = 0;

        public void AddMoon(Planet newMoon)
        {
            this.Moons.Add(newMoon);
            newMoon.Parent = this;
        }


    }
}
