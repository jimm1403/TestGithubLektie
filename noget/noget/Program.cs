﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
               
        }

        public void Run()
        {
            Console.WriteLine("Hej Jens, det virker nu.");
            Console.WriteLine("Det virker aldrig :P ");
            Console.ReadKey();
        }
    }
}
