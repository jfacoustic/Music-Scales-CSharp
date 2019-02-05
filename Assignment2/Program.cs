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
                Console.WriteLine("Here are some tests:");
                MajorScale CSharpMajor = new MajorScale(Chromatic.Cs);
                CSharpMajor.PrintScale();
                MajorScale FSharpMajor = new MajorScale(Chromatic.Fs);
                FSharpMajor.PrintScale();
                NaturalMinorScale DMinor = new NaturalMinorScale(Chromatic.D);
                DMinor.PrintScale();
                NaturalMinorScale AMinor = new NaturalMinorScale(Chromatic.A);
                AMinor.PrintScale();
            }
            else if(args[0] == "--i")
            {
                bool running = true;
                while(running)
                {
                    Console.WriteLine("Enter a musical note -- no flats! (Ex: Cs)");
                    string n = Console.ReadLine();
                    try
                    {
                        Chromatic note = (Chromatic)Enum.Parse(typeof(Chromatic), n);
                        Console.WriteLine("Major (M) or minor (m)?");
                        string s = Console.ReadLine();
                        if (s == "M")
                        {
                            MajorScale scale = new MajorScale(note);
                            scale.PrintScale();
                        }
                        else if (s == "m")
                        {
                            NaturalMinorScale scale = new NaturalMinorScale(note);
                            scale.PrintScale();
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Sorry, invalid note.");
                    }
                    Console.WriteLine("Want to try again?  (y/n)");
                    string again = Console.ReadLine();
                    if (again == "n")
                    {
                        running = false;
                    }
                }
            }
        }
    }
}
