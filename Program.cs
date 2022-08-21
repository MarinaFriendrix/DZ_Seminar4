//Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B


// Console.Write("Введите первое число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int prod = 1;

// for (int i = 1; i <= B; i++)
// {
//     prod *= A;
// }

// Console.WriteLine(prod);

//Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int GetSumNums(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");


// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


Console.WriteLine ("Введите число 1 = ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число 2 = ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число 3 = ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число 4 = ");
int num4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число 5 = ");
int num5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число 6 = ");
int num6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число 7 = ");
int num7 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число 8 = ");
int num8 = Convert.ToInt32(Console.ReadLine());

int [] array = new int [] {num1, num2, num3, num4, num5, num6, num7, num8};

for(int i = 0; i<array.Length; i++)
{
    Console.Write(" " + array[i]);
}








