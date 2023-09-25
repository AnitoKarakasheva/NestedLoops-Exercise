using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем начало и край на диапазона 
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            //2. Създаваме цикъл, който да се изпълнява от 1вото число в диапазона до последното
            for (int num = first; num <= second; num++)
            {
                int oddSum = 0;
                int evenSum = 0;

                string currentNum = num.ToString();

                //=> 3. Създаваме цикъл, който да преминава през всички цифри от текущото число 
                for (int i = 0; i < currentNum.Length; i++)
                {
                    // ==> проверяваме текущата цифрата дали е на четна/нечетна позиция
                    if (i % 2 == 0)
                    {
                        // ===> при четна позиция: добавяме числото към сумата на числата на четна позиция
                        evenSum += currentNum[i];
                    }
                    else
                    {
                        // ===> при НЕчетна позиция: добавяме числото към сумата на числата на НЕчетна позиция
                        oddSum += currentNum[i];
                    }
                }

                //=>4. Проверяваме дали сумите са равни
                //==> ако са: отпечатваме числото
                if (evenSum == oddSum)
                {
                    Console.Write(currentNum + " ");
                }
            }

        }
    }
}
