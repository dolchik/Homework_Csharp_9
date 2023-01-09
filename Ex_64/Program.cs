// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void PrintNumbers(int number)
{
    if (number >= 1)
    {
        Console.Write($"{number} ");
        PrintNumbers(number - 1);
    }
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//запрашиваем у пользователя число N
int N = EnterNumber("Введите число N:");
//рекурсия, которая выводит все числа в промежутке от N до 1
PrintNumbers(N);