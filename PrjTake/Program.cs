using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PrjTake.Utilities.Math;

namespace PrjTake
{
    class Program
    {
        static void Main(string[] args)
        {
            Super Super = new Super();
            Super.Init(Encoding.Default.GetBytes("PrjTake"));
            Console.WriteLine(Super.Next());

            while (true)
                Console.Read();
        }
    }
}
