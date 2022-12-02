// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int number = Prompt("Введите число");
                                          //Отрезается одна цифра сзади и одна спереди
if (number >= 100 && number < 1000)    //  Проверить трехзначность
{
    int result = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра введенного числа {result}");
}
else 
{
    System.Console.WriteLine("Число не трехзначное");
}