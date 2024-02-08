using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) 
        {
             int levels = 5;
            for (int i = 0; i < levels; i++)
            {
                for (int j = 0; j < levels - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}