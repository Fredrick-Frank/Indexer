using System;
using System.Collections.Generic;

namespace Indexer
{
    public class Program
    {
        public static void Main()
        {
            StringDataStore<int> grades = new StringDataStore<int>();
            grades[0] = 100;
            grades[1] = 300;
            grades[2] = 150;
            grades[3] = 590;
            grades[4] = 900;
            grades[5] = 600;

            for(int i = 0; i < grades.Length; i++)
                Console.WriteLine(grades[i]);
        }
    }
}