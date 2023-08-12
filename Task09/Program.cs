// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

using System.Globalization;

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапозона 10 - 99 -> {number}");
int  maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра = {maxDigit}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра = {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра = {secondDigit}");
// }
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit)
    // {
    //     return firstDigit;
    // }
    return firstDigit > secondDigit ? firstDigit: secondDigit;
}
