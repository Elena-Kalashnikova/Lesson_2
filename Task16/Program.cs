// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число:");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number_2 = Convert.ToInt32(Console.ReadLine());
bool result = Square(number_1, number_2);
Console.WriteLine(result ? "Да" : "Нет");

bool Square(int num_1, int num_2){
    return num_1*num_1 == num_2 || num_2 * num_2 == num_1; 
}