// Joshua Mathews
// Assignment 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLib;

namespace Assignment2
{
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                MajorScale CSharpMajor = new MajorScale(Chromatic.Cs);
                CSharpMajor.PrintScale();
                MajorScale FSharpMajor = new MajorScale(Chromatic.Fs);
                FSharpMajor.PrintScale();
                NaturalMinorScale DMinor = new NaturalMinorScale(Chromatic.D);
                DMinor.PrintScale();
                NaturalMinorScale AMinor = new NaturalMinorScale(Chromatic.A);
                AMinor.PrintScale();
            }
        }
    }
}
