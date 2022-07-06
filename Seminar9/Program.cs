/*Задача1
void ShowNums(int n)
{
    if(n != 1)
      ShowNums (n -1);

    Console.Write(n + " ");
}

Console.WriteLine("Input integer positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/

/*Задача2
void ShowNums(int n, int m)
{
    if(n != m)
      ShowNums (n -1, m);

    Console.Write(n + " ");
}

Console.WriteLine("Input integer min number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input integer max number: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n, m);
*/

/*Задача3
int Sum(int num)
{
    if(num == 0)
    
       return 0;
       return num % 10 + Sum(num / 10);
    
}
Console.WriteLine("Input integer max number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(num));
*/

/*Задача4
int Degree(int a, int b)
{
    if (b != 0)
    return a * Degree(a, b - 1);
    else
     return 1;
}

Console.WriteLine("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input integer degree: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(a, b));
*/

/*
// для отрицательных чисел
double Degree(int a, int b)
{
    if (b > 0)
    return a * Degree(a, b - 1);
    else
    if (b < 0)
         return 1 /(a * Degree(a, - b - 1));
    else
         return 1;
}

Console.WriteLine("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input integer degree: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(a, b));
*/