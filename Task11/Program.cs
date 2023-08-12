// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число из диапозона 100 - 999 ->{number}");
int resultDigit = DeleteSecondDigit(number);
Console.WriteLine($"Число без второй цифры = {resultDigit}");

int DeleteSecondDigit(int num){
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int resDigit = firstDigit * 10 + lastDigit;
    return resDigit;
  

}
