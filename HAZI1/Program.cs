using System;
using static System.Console;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// http://example.com/galleryFX/1.jpg
// http://example.com/galleryFX/2.jpg
// http://example.com/galleryFX/3.jpg
// http://example.com/galleryFX/4.jpg
// http://example.com/galleryFX/5.jpg
// http://example.com/galleryFX/6.jpg
// http://example.com/galleryFX/7.jpg
// http://example.com/galleryFX/8.jpg
// http://example.com/galleryFX/9.jpg
// http://example.com/galleryFX/10.jpg
// http://example.com/galleryFX/11.jpg
// http://example.com/galleryFX/12.jpg
// http://example.com/galleryFX/13.jpg
// http://example.com/galleryFX/14.jpg
// http://example.com/galleryFX/15.jpg

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string template = "http://example.com/galleryFX/{0}{1}.jpg";
            // for (int i = 1; i <= 15; i++)
            // {
            //     var url = string.Format(template, i);
            //     Console.WriteLine(url);
            // }

             for (int i = 1; i <= 15; i++)
        {
            string url = string.Format("http://example.com/galleryFX/{0:D2}.jpg", i);
            Console.WriteLine(url);
        }

        }
    }
}
