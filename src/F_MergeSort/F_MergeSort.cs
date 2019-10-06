using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


public class F_MergeSort
{




    static void Main1(string[] args)
    {
        using (var reader = new ConsoleReader())
        {
            var n = int.Parse(reader.ReadLine());
            if (n < 1) return;

            var lines = new List<Line>(n);

            for (int i = 0; i < n; i++)
            {
                var str = reader.ReadLine();
                lines.Add(new Line(GetLength(str), ParseDigits(str)));
            }



            Console.WriteLine(string.Join(" ", lines[0].Values));
        }
    }   
}