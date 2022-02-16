using System;

namespace Diamante.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diamante = 0;
            while (diamante % 2 == 0)
            {
                Console.WriteLine("ESCREVA UM VALOR IMPAR PARA GERAR UM DIAMANTE!");
                diamante = int.Parse(Console.ReadLine());
                Console.Clear();
            }
                int gerar = diamante / 2;
                Console.Clear();
            
                for (int i = 0; i <= gerar; i++)
                {
                    for (int j = 0; j < gerar - i; j++)
                    {
                        Console.Write(" ");
                    }

                    int var = (i * 2) + 1;
                    for (int j = 0; j < var; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("W");
                        }
                        else
                        {
                            Console.Write("V");
                        }
                }
                    Console.WriteLine();
                }

                for (int i = gerar - 1; i >= 0; i--)
                {
                    for (int j = 0; j < gerar - i; j++)
                    {
                        Console.Write(" ");
                    }

                    int var = (i * 2) + 1;
                    for (int j = 0; j < var; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("W");
                        }
                        else
                        {
                            Console.Write("V");
                        }
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            
        }
    }
}
