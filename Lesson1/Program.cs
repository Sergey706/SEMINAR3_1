// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");
int number1 = Convert.ToInt32(Console.ReadLine());
int i =5;
i = -number1;
System.Console.Write(i);

// // Напишите программу, которая принимает на вход
// // трёхзначное целое число и на выходе показывает сумму
// // первой и последней цифры этого числа.
// // 456 => 10
// // 782 => 9
// // 918 => 17

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// 1004
//  TRUE         И   FALSE  
if (99 < number && number < 1000)
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int result = leftDigit + rightDigit;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Число НЕ трехзначное");
}

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Write("Введите целое положительное число: ");
int number2 = Convert.ToInt32(Console.ReadLine()); // number = 3

// int i = -number; // i = -3
//         // -1 <= 3
// while (i <= number)
// {
//     //                  -1 
//     System.Console.Write(i + " ");
//     i++; // i = i + 1 // i += 1
// }

for (int a = -number2; a <= number2; a++)
{
    System.Console.Write(a + " ");
}