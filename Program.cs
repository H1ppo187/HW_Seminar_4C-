// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16




// // ----------------------Метод--------------

Console.WriteLine("Введите 2 числа ");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в стеепени {B} равно {ResulDegree(A, B)}");

int ResulDegree(int Number, int Degree)
{
    int sum = Number;
    for (int i = 2; i <= Degree; i++)
    {
        sum = sum * Number;
    }
    return sum;
}