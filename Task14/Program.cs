﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да



using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Multiplicity(number);
Console.WriteLine(result ? "Да" : "Нет");


// int Multiplicity_7_23(int num){
//   return num % 7 % 23;
// }
bool Multiplicity (int num){
    return num % 7 == 0 && num % 23 == 0;
}
