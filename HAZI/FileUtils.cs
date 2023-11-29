using System;
using static System.Console;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Example
{
    public static class FileUtils
    {
        public static List<string> ReadLines (string fname)
        {
            List<string> lista = new List<string>();
            {
                using (var f = new StreamReader(fname))
                {
                string line;
                while((line = f.ReadLine()) != null)
                {
                    lista.Add(line);

                }
                }
            }
            return lista;
        }

        public static List<int> ReadLinesAsInts (string fname)
        {

            List<string> lista = ReadLines (fname);

            return lista.Select(int.Parse).ToList();


        }
    }


}
