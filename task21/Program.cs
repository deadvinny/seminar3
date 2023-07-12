// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// AB = √((xb - xa)2 + (yb - ya)2)




double Distance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return distance;
}



int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

// distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

int x1 = GetInfo("Введите первую координату первой точки: ");
int y1 = GetInfo("Введите вторую координату первой точки: ");
int x2 = GetInfo("Введите первую координату второй точки: ");
int y2 = GetInfo("Введите вторую координату второй точки: ");

Console.WriteLine($"Расстояние между двумя точками на плоскости равно {Distance(x1, y1, x2, y2)}");