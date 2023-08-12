// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число:");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number_2 = Convert.ToInt32(Console.ReadLine());
int result = IsMultiplicity(number_1, number_2);
if (result == 0)
{

    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Некратно, остаток = {result}");
}

int IsMultiplicity(int num_1, int num_2)
{
    return num_1 % num_2;
}


