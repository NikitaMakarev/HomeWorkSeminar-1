/*Задача66
void ShowNums(int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum += m++;
    ShowNums(m, n, sum);
}

Console.WriteLine("Input integer positive number1: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input integer positive number2: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(m, n, 0);
*/

/*Задача67
int Number(int a)
{
    if(a >= 0 && a <= 10)
    
       return 1;
       else
       return 1 + Number(a / 10);
    
}
Console.WriteLine("Input integer number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number(b));
*/