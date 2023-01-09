// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int M, int N)
{
    if (M == N) return N;
    return SumNumbers(M + 1, N) + M;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//запрашиваем у пользователя число N
int M = EnterNumber("Введите число M:");
int N = EnterNumber("Введите число N: ");
//рекурсия, которая выводит все числа в промежутке от 1 до N
if (M <= N)
{
    int sum = SumNumbers(M, N);
    Console.WriteLine($"Сумма натуральных элементов от M до N: {sum}");
}
else Console.WriteLine("некоректный ввод");