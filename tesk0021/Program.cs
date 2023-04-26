// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double GetDistanceXY(double ax, double ay, double bx, double by ) 
{
   double distance = Math.Pow( ax - ay, 2) + Math.Pow(bx - by, 2); 
   distance = Math.Sqrt(distance);
   distance = Math.Round(distance, 2); 
    return distance;
}

System.Console.WriteLine("Ввежите первое число по Х");
double ax = double.Parse(Console.ReadLine()!);
System.Console.WriteLine("Ввежите 2 число по Y");
double bx = double.Parse(Console.ReadLine())!; 
System.Console.WriteLine("Ввежите 1 число по X ");
double ay = double.Parse(Console.ReadLine())!;
System.Console.WriteLine("Ввежите 2 число по Y");
double by = double.Parse(Console.ReadLine())!;


System.Console.WriteLine("расстояние между точками = " + GetDistanceXY(ax, ay, bx, by));
