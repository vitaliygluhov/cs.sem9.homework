namespace sem9_hw;
using vgnamespace;

class Program
{
    static void Main(string[] args)
    {
        /* Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет 
        все натуральные числа кратные 3-ём в промежутке от M до N.
        M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18" */
        void Task64()
        {
            int[] UserInput = IO.MultiInputInt("Введите числа M и N");
            Console.Clear();
            void ShowNumbers(int NumberM, int NumberN) // собственно сам рекурсивный метод
            {
                if (NumberM <= NumberN)
                {
                    if (NumberM % 3 == 0)
                        Console.Write($"{NumberM} ");
                    ShowNumbers(NumberM + 1, NumberN);
                }
            }
            ShowNumbers(UserInput[0], UserInput[1]);
        }
        /* 
        Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в 
        промежутке от M до N.
        M = 1; N = 15 -> 120
        M = 4; N = 8. -> 30 
        */
        void Task66()
        {
            Console.Clear();
            int[] UserInput = IO.MultiInputInt("Введите числа M и N");
            int CalcSum(int NumberM, int NumberN) // собственно сам рекурсивный метод
            {
                int Sum = NumberM;
                if (NumberM == NumberN) return 0;
                else
                {
                    NumberM++;
                    Sum = NumberM + CalcSum(NumberM, NumberN);
                    return Sum;
                }
            }
            Console.Write($"Сумма натуральных элементов в промежутке от {UserInput[0]} до {UserInput[1]} равна {CalcSum(UserInput[0] - 1, UserInput[1])}.");
        }
        /*
        Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
        Даны два неотрицательных числа m и n.
        m = 3, n = 2 -> A(m,n) = 29
        */
        void Task68()
        {
            Console.Clear();
            int[] UserInput = IO.MultiInputInt("Введите числа M и N");
            int AkkermanFunction(int NumberM, int NumberN) // собственно сам рекурсивный метод
            {
                if (NumberM == 0) return NumberN + 1;
                else if (NumberN == 0 && NumberM > 0) return AkkermanFunction(NumberM - 1, 1);
                else return (AkkermanFunction(NumberM - 1, AkkermanFunction(NumberM, NumberN - 1)));
            }
            Console.Write($"Результат вычисления функции Аккермана равен {AkkermanFunction(UserInput[0] - 1, UserInput[1])} при M={UserInput[0]} и  N={UserInput[1]}.");
        }

        //проверка заданий
        //Task64();
        //Task66();
        //Task68();

    }
}
