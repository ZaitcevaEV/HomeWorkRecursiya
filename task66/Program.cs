// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

class Program
{
    static int GetSumOfNaturalNumbersInRange(int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++)
        {
            sum += i;
        }

        return sum;
    }
        static void Main()
    {
        Console.WriteLine("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (m <= n)
        {
            int sum = GetSumOfNaturalNumbersInRange(m, n);
            Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}: {sum}");
        }
        else
        {
            Console.WriteLine("Ошибка: M должно быть меньше или равно N.");
        }
    }

}
