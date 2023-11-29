using System;
using static System.Console;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // List<string> sorok = FileUtils.ReadLines("in.txt");
            List<int> sor = FileUtils.ReadLinesAsInts("in.txt");
            WriteLine(string.Join("\n", sor));
        }
    }


}
