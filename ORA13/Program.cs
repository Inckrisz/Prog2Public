using System;
using static System.Console;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class Program
    {
        // private final static int N = 1000; java
        private const int N = 1000;
        private static Random rand = new Random();
        public static void Main(string[] args)
        {
            // Console.WriteLine(string.Format("# Hello {0}", args[0]));
            // if (args.Length != 1)
            // {
            //     WriteLine("Hiba, 1 parancssori argumentumot adj meg!");
            //     Environment.Exit(1);
            // }
            // var name = args[0];
            // WriteLine($"Hello {name}");
            
            // Console.WriteLine("# Hello " + name + "!");

            // var argok = Environment.GetCommandLineArgs();
            // parancss 2 db számot 2 szám összege
            // if (argok.Length != 3)
            // {
            //     WriteLine("Hiba, 2 parancssori argumentumot (számot) adj meg!");
            //     Environment.Exit(1);
            // }

            // WriteLine(int.Parse(argok[1]) + int.Parse(argok[2]));

            //felhaszn bekérünk egy sort -> int

            // Write("Szám: ");
            // try
            // {
            // var text = Console.ReadLine();
            // int value = int.Parse(text);

            // WriteLine($"{value} + 1 = {value + 1}");
            // }
            // catch (FormatException e)
            // {
            //     WriteLine("Helló! Számot kellene megadni!");
            //     WriteLine(e.Message);
            // }
            // finally 
            // {
            //     WriteLine("ez meg mindig lefut");
            // }

            // a().

            // WriteLine("Bye");

            // List<int> szamok = new List<int> {2,3,5,7,11,13};

            // var result = szamok.Any(x => x > 5); 

            // WriteLine(string.Join(", ", szamok));
            // WriteLine(result);

            // int[] scores = new int[10];
            // WriteLine(string.Join(", ", scores));

            // int[] pontok = {2, 3, 5, 7};

            // WriteLine(string.Join(", ", pontok));

            // string[] nevek = new string[10];

            // WriteLine(string.Join("", nevek));

            // int[,] matrix = {
            //     {1, 2, 3},
            //     {4, 5, 6},
            //     {7, 8, 9}
            // };

            // for (var sor = 0; sor < matrix.GetLength(0); sor++)
            // {
            //     for (var oszlop = 0; oszlop < matrix.GetLength(1); ++oszlop)
            //     {
            //         Write(matrix[sor,oszlop]);
            //         Write(" ");
            //     }
            //     WriteLine();
            // }

            // var sb = new StringBuilder();
            // sb.Append("a");
            // sb.Append(32);
            // var result = sb.ToString();
            // WriteLine(result);

            // const int N = 1000;
            
            Random rand = new Random();

            WriteLine(rand.Next(11)); // [0,11)
             WriteLine(rand.Next(5, 11)); //[5,11)
             WriteLine(rand.NextDouble()); // [0.0, 1.0]

        }

        private static object a()
        {
            throw new NotImplementedException();
        }
    }


}
