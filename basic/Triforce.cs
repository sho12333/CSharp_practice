using System;

namespace SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;

            for (int i = 0; i < num; i++) {
                for(int j = 0; j < 4; j++) {
                    Console.Write(" ");
                }
                for(int j = 0; j < num-i; j++) {
                    Console.Write(" ");
                }
                for(int k = 0; k <= (i*2); k++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < num; i++) {
                for(int j = 0; j < num-i; j++) {
                    Console.Write(" ");
                }
                for(int k = 0; k <= (i*2); k++) {
                    Console.Write("*");
                }
                for(int j = 0; j < num-i; j++) {
                    Console.Write(" ");
                }
                for(int j = 0; j < num-i-1; j++) {
                    Console.Write(" ");
                }
                for(int k = 0; k <= (i*2); k++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
