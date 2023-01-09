// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AckermanFunction(int M, int N)
{
    if(M == 0) return N + 1;
    if( M > 0 && N == 0) return AckermanFunction(M - 1, 1);
    else return AckermanFunction(M - 1, AckermanFunction(M, N -1));
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
//рекурсия. Функция Аккермана
int Ackerman = AckermanFunction(M, N);
Console.WriteLine(Ackerman);