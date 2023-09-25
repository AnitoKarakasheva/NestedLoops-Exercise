using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNum = 1;

            //този цикъл се гриви за конкретните редове
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(currentNum + " ");
                    currentNum++;

                    if (currentNum > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();

                if (currentNum > n)
                {
                    break;
                }
            }
        }
    }
}
