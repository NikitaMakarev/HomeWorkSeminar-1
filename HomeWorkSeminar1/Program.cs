/* Задача1
int num1, num2;

Console.Write ("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine ());

Console.Write ("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine ());

if (num1 > num2)
{
    Console.WriteLine("num1");
}
else
{
    Console.WriteLine("num2");
}
// Задача решена, программа выводит наибольшее число.
*/

/* Задача2
int num1, num2, num3;

Console.Write ("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine ());

Console.Write ("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine ());

Console.Write ("Input third integer number: ");
num3 = Convert.ToInt32(Console.ReadLine ());

if (num1 > num2)
{
    Console.WriteLine("Nubmer Max -" + num1);
}
else 
if (num2 > num3)
{
    Console.WriteLine("Nubmer Max -" + num2);
}
else
{
    Console.WriteLine("Nubmer Max -" + num3);
}
*/

/* Задача3
int num;

Console.Write ("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine ());


if (num % 2 == 0 )
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
// Оператор остатка % вычисляет остаток от деления левого операнда на правый.
*/

/* Задача4
int num;

Console.Write ("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine ());

int current = 2 ;

while(current <= num)
{
    Console.Write(current + " ");
    current = current + 2; 
}
*/