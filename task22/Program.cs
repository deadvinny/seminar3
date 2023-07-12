// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4



void Square(int numN)
{
    Console.Write($"{numN} -> ");
    for (int i = 1; i <= numN; i++)
    {
       if (i < numN) Console.Write($"{i * i}, " );
       else Console.Write($"{i * i}." );
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}

int numN = GetInfo("Введите число: ");
Square(numN);