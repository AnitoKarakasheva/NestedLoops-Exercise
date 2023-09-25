using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем вход от конзолата (string) 
            string input = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            //1. Създаваме цикъл, който да се изпъкнява до получаване на командата "stop"
            while (input != "stop")
            {
                //=> преобразуваме входът в число 
                int num = int.Parse(input);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                //=> 2) приемаме, че числото е просто
                bool isPrime = true;

                //==> пускаме цикъл, който да се изпълнява от 2 до числото-1 (вкл.) 
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                //=> 3) В зависимост дали числото е просто или не, го добавяме към съответната сума
                if (isPrime)
                    primeSum += num;
                else
                    nonPrimeSum += num;

                //=> четем нов вход от конзолата
                input = Console.ReadLine();
            }

            //2. Отпечатваме резултата на конзолата
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
