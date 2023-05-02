// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double GetDistanceXY(double ax, double ay, double bx, double by ) 
{
   double distance = Math.Pow( bx - ax, 2) + Math.Pow(by - ay, 2);
   distance = Math.Sqrt(distance);
    
    return distance;
}

System.Console.WriteLine("Ввежите координату первой точки по оси Х(ах) ");
double ax = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координату первой точки по оси Y(ay)");
double ay = double.Parse(Console.ReadLine())!; 
System.Console.WriteLine("Введите координату второй точки по оси Х(bx) ");
double bx = double.Parse(Console.ReadLine())!;
System.Console.WriteLine("Введите координату второй точки по оси Y(by)");
double by = double.Parse(Console.ReadLine())!;


System.Console.WriteLine("расстояние между точками = " + GetDistanceXY(ax, ay, bx, by));
