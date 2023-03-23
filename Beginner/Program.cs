using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beginner
{
    class Program
    {
        static void Main(string[] args)
        {

            var name = "Aminu";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found seven");
                    break;

                }
                Console.WriteLine(name);
            }
        }
    }
}
