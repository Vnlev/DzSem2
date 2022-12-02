// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int number = Prompt("Введите число");
while  (number >= 1000) 
{
        number = number/10;
}                                   
if (number >= 100 && number < 1000)    //  Проверить трехзначность
{
    int result = number % 10;
    System.Console.WriteLine($"Третья цифра введенного числа {result}");
}
else 
{
        System.Console.WriteLine("Третьей цифры нет");
}