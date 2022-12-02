// Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98


Random rnd = new Random();
int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

// int number = Prompt("Введите число");
int number = rnd.Next()%1000;
                                          //Отрезается одна цифра сзади и одна спереди
if (number >= 100 && number < 1000)    //  Проверить трехзначность
{
    int result = number / 100;
    int result2 = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра случайного числа удалена! {result} {result2}");
}
else 
{
    System.Console.WriteLine("Число не трехзначное");
}