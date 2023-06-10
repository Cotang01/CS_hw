/******************************************************************************

Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех 
натуральных числел в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения 
суммы натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*******************************************************************************/

using System;
class homework_9 {
    
   static void Main(string[] args)
    {
        // Задача 64
        Console.Write("\nВведите число: ");
        int num;
        num = int.Parse(Console.ReadLine()); 
        RecursiveNumsPrint(num);
        
        // Задача 66
        int m, n;
        Console.Write("\nВведите m: ");
        m = int.Parse(Console.ReadLine());
        Console.Write("\nВведите n: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", 
        m, n, Sum(m,n));
        
        // Задача 68
        int m1, n1;
        Console.Write("\nВведите m1: ");
        m1 = int.Parse(Console.ReadLine());
        Console.Write("\nВведите n1: ");
        n1 = int.Parse(Console.ReadLine());
        int result = Ackermann(m1, n1);
        Console.WriteLine($"Ackermann({m1}, {n1}) = {result}");
        
    }

    public static void RecursiveNumsPrint(int num) // Метод к задаче 64
    {
        if (num > 0)
        {
            Console.Write(num + " ");
            RecursiveNumsPrint(num - 1);
        }
    }
    
    public static int Sum(int m, int n) // Метод к задаче 66
    {
        if (n == m) 
        {
            return m;
        }
        else
        {
            return n + Sum(m, n - 1);
        }
    }
    
    public static int Ackermann(int m1, int n1) // Метод к задаче 68
    {
        if (m1 == 0)
        {
            return n1 + 1;
        }
        else if (n1 == 0)
        {
            return Ackermann(m1 - 1, 1);
        }
        else
        {
            return Ackermann(m1 - 1, Ackermann(m1, n1 - 1));
        }
    }
}
