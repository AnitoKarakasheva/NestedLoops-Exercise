using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int ppl = int.Parse(Console.ReadLine());
            double finalAss = 0;
            int countAss = 0;
            while (true)
            {

                string pres = Console.ReadLine();
                if (pres == "Finish") { Console.WriteLine($"Student's final assessment is {finalAss / countAss:f2}."); break; }
                double grade = 0.00;
                countAss++;
                for (int i = 1; i <= ppl; i++)
                {
                    grade += double.Parse(Console.ReadLine());
                    if (i == ppl) { finalAss += grade / ppl; Console.WriteLine($"{pres} - {grade / ppl:f2}."); break; }
                }
            }
        }
    }
}
