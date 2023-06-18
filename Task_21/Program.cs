// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// // Возведение в степень
// double number = 9;
// System.Console.WriteLine(Math.Pow(number, 2));

// // Извлечение квадратного корня
// System.Console.WriteLine(Math.Sqrt(number));

// // Округление дробного числа
// double num = 1.123213213213;
// System.Console.WriteLine(Math.Round(num, 2));

// // Комбинация
// System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(num, 3)), 2));

// √((хА – хВ)^2 + (уА – уВ)^2 + (zA - zB)^2


double distanse3D(double xA, double yA, double zA,
                  double xB, double yB, double zB)
{
    double Distanse = Math.Sqrt(Math.Pow((xA - xB), 2)
     + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB ), 2));
    return Math.Round(Distanse, 2);
}

System.Console.WriteLine("Введите координату xA:");
int xA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату yA:");
int yA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату zA:");
int zA = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Введите координату xB:");
int xB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату yB:");
int yB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату zB:");
int zB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(distanse3D(xA,yA,zA,xB,yB,zB));

