// Задача №17: Напишите программу , которая принимает на вход координаты точек (X, Y) причем X не равно 0 и Y не равно 0. 
// И выдает номер четверти плоскости, в которой находится эта точка.

/*int GetNumberOfQuarter(int x, int y)
{
    if( x == 0 || y == 0)
    {
        return - 1; 
    }
    if( x > 0 && y > 00)
    {
        return 1;
    }
    else if( x < 0 && y > 0)
    {
        return 2;
    }
    else if( x < 0 && y < 0)
    {
        return 3;
    }
    else
    {
        return 4;
    }
    
}
Console.WriteLine(GetNumberOfQuarter(3, 5));
Console.WriteLine(GetNumberOfQuarter(-5, 2));
Console.WriteLine(GetNumberOfQuarter(-5, -2));
Console.WriteLine(GetNumberOfQuarter(5, -2));
Console.WriteLine(GetNumberOfQuarter(0, -2));
Console.WriteLine(GetNumberOfQuarter(0, 0));
*/

/*int[] arr = {1, 2, 3, 4, 5, 60, 70};
string result = string.Join(";         ", arr);

Console.WriteLine(result);
*/

string input = "1 2 3 4 5";
var result = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
// "1 2 3 4 5"
// "1", "2", "3", "4", "5"
// 1, 2, 3, 4, 5
foreach (var num in result)
{
    Console.Write(num + " ");   
}
Console.WriteLine();

for( int i = 0; i < result.Length; i ++)
{
    Console.Write(result[i] + " ");
}
Console.WriteLine();
int number = 2;

int nummber2 = 3;

int result2 = number * nymber2;
Console.WriteLine(result2);