// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

using System;

class Program
{
    static string GetNaturalNumbersInRange(int start, int end)
    {
        string result = "";

        for (int i = start; i <= end; i++)
        {
            if (i > start)
            {
                result += ", ";
            }
            result += i;
        }

        return result;
    }
    static void Main()
    {
        Console.WriteLine("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (m <= n)
        {
            string result = GetNaturalNumbersInRange(m, n);
            Console.WriteLine($"\"{result}\"");
        }
        else
        {
            Console.WriteLine("Ошибка: M должно быть меньше или равно N.");
        }
    }
}
