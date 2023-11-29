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
            List<int> lista = FileUtils.ReadLinesAsInts("in.txt");
            var result = lista.SelectMany(exp1 => lista.Where(exp2 => exp1 + exp2 == 2020))
                 .FirstOrDefault();
            WriteLine(result + " " + (2020-result));
        }
    }
}
