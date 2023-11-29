using System;
using static System.Console;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Example
{
    public class PyUtils
    {
        public static List<int> Range (int start, int end, int step)
        {
            List<int> result = new List<int>();

            for (int i = start; i < end; i+=step)
            {
                result.Add(i);
            }

            return result;
        }

        public static List<int> Range(int start, int end) {
        return Range(start, end, 1);
    }

    public static List<int> range(int end) {
        return Range(0, end);
    }
    }
}
