﻿using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. създаваме променливи, които да пазят броя продадени билети от всяка категория
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            string filmName = Console.ReadLine();

            //2.Създаваме цикъл за отделните прожекции до получаване на командата "Finish"
            while (filmName != "Finish")
            {
                //=> четем броя на свободните места в залата
                int free = int.Parse(Console.ReadLine());

                string type = Console.ReadLine(); //"student", "standard", "kid", "End"
                int tickets = 0;

                //=> създаваме цикъл, който да се изпълнява до получаване на командата "End"
                while (type != "End")
                {
                    //==> увеличаваме броя на съответната категория билети
                    if (type == "student")
                        studentTickets++;
                    else if (type == "standard")
                        standardTickets++;
                    else
                        kidTickets++;

                    //==> увеличаваме броя на продадените билети за КОНКРЕТНАТА прожекция
                    tickets++;
                    //==> проверяваме дали броя на свободните места за КОНКРЕТНАТА прожекция == броя продадени билети
                    if (tickets == free)
                        break;

                    //==> четем тип продаден билет 
                    type = Console.ReadLine();
                }

                //=> изчисляваме какъв процент от залата е запълнена
                Console.WriteLine($"{filmName} - {(double)tickets * 100 / free:f2}% full.");

                //=> четем нов вход от конзолата (име на филм)
                filmName = Console.ReadLine();
            }

            //3. Намираме колко общо билета са продадени от всички прожекции и отпечатвае на конзолата
            int totalTickets = studentTickets + standardTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");

            //4. Намираме какъв % от всички билети са били student/standard/kid и отпечатвае на конзолата
            Console.WriteLine($"{(double)studentTickets * 100 / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{(double)standardTickets * 100 / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidTickets * 100 / totalTickets:f2}% kids tickets.");

        }
    }
}
