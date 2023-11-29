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
            List<string> jarmu = new List<string>{"auto", "villamos", "metro"};
            WriteLine(string.Join(", ", jarmu.Select(j => j.ToUpper())));
            List<string> nevek = new List<string> {"aladar", "bela", "cecil"};
            WriteLine(string.Join(", ", nevek.Select(n => char.ToUpper(n[0])+ n.Substring(1))));
        }
    }
}

// 1. feladat

// ['auto', 'villamos', 'metro'] → ['AUTO!', 'VILLAMOS!', 'METRO!']

// 2. feladat

// ['aladar', 'bela', 'cecil'] → ['Aladar', 'Bela', 'Cecil']

// 3. feladat

// [0, 0, 0, 0, 0, 0, 0, 0, 0, 0], azaz inicializáljunk egy 10-elemű listát csupa 0-val.

// 4. feladat

// [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] → [2, 4, 6, 8, 10, 12, 14, 16, 18, 20]

// 5. feladat

// ['1', '2', '3', '4', '5', '6', '7', '8', '9', '10'] → [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] (az első listában sztringek vannak)
