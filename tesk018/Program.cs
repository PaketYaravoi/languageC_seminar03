// Напишите программу которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (X ,Y).


string interval(int number)
{
    string interval = "Введеное Вами число не верно, пожалуйста введите число от 1 до 4";
    
    if(number == 1)
    {
        interval = "x in (0; +inf); y in (0; +inf";
    }
    else if(number == 2 )
    {
        interval = "x in (0; -inf); y in (0; +inf";
    }
    else if(number == 3 )
    {
        interval = "x in (0; -inf); y in (0; -inf";
    }
    else if(number == 4 )
    {
        interval = "x in (0; +inf); y in (0; -inf";
    }
    return interval;
}

Console.WriteLine("Enter qyarter number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(interval(number));