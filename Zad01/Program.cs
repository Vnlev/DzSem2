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
int result = number/10 % 10;                  //Отрезается одна цифра и одна спереди
System.Console.WriteLine(result);