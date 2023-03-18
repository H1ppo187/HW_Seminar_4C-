// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16




// // ----------------------Метод--------------

// Console.WriteLine("Введите 2 числа ");
// int A = int.Parse(Console.ReadLine()!);
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {A} в стеепени {B} равно {RezultDegree(A, B)}");

// int RezultDegree(int Number, int Degree)
// {
//     int sum = Number;
//     for (int i = 2; i <= Degree; i++)
//     {
//         sum = sum * Number;
//     }
//     return sum;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.WriteLine("Введите число ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр в числе {A} равно {SumOfNumber(A)}");

//----------------------Метод--------------

// int SumOfNumber(int number)
// {
//     int sum = 0;
//     sum = number % 10;
//     number = number / 10;
//     while (number > 0)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }
//     return sum;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int number = 8;
int[]massive =FillMass(number);
Console.WriteLine($"[{String.Join("; ", massive)}]");

// ---------~~Метод~~-------------//
int[] FillMass(int size)
{
    int[] Rezult = new int[size];
    for (int i = 0; i < size; i++)
    {
        Rezult[i] = new Random().Next(100);
    }
    return Rezult;
}
