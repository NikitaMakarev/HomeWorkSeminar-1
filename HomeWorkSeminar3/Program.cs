/*Задача23
void Quad(int num)
{
    int current = 1;
    while(current <= num)
    {
       Console.WriteLine((current * current * current) + " ");
       current++; 
    }
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Quad(num);
*/

/*Задача19
void ChekingNumber(string number)
{
    
    if (number [0] == number [4] && number [1] == number [3])
{
    Console.WriteLine("Число - палиндром");
}

    else Console.WriteLine("Число - не палиндром");
}

Console.WriteLine ("Введите пятизначное число");
string number = Console.ReadLine();

ChekingNumber(number);
*/

/*Задача21
double FindLenght(double xA, double yA, double zA, double xB, double yB, double zB )
{
    return Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((yB - yA),2) +  Math.Pow((zB - zA),2));
}

Console.Write("Введите координаты xA: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты yA: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты zA: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты xB: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты yB: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты zB: ");
double zB = Convert.ToDouble(Console.ReadLine());

double result = FindLenght(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками {Math.Round(result,2)}");
*/