/*// See https://aka.ms/new-console-template for more information
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
*/
/*
//Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
using System;
using System.Runtime.InteropServices.Marshalling;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        if (firstNumber == secondNumber){
            System.Console.Write($"Числа равны");
        }
        else{
            if (firstNumber > secondNumber){
                System.Console.Write($"Первое число больше");
            }
            else System.Console.Write($"Второе число больше");
        }
    }

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 7;
            secondNumber = 9;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}
*/

/*//Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел
using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
      // Введите свое решение ниже
        if (a >= b && a >= c)
        {
           return a; 
        }
        else
        {
            if (b >= a && b >= c) return b;
            else return c;
        }
    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 6;
           b = 5;
           c = 4;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}*/
/*//Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

using System;

class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже
        if (number % 2 == 0)
        {
            System.Console.WriteLine($"четное");
        }
        else System.Console.WriteLine($"нечетное");

    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = -8;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}*/

//Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.
using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.Write($"{i} ");
            }
        }
    }

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 8;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}
