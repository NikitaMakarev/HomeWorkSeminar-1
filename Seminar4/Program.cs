// 43712 % 10 = 2
/*Задача1
int FindSumOfDigits(int num)
{
    int sum = 0;

    while(num > 0)
    {
        sum = sum + num % 10; // sum += num % 10 - тоже самое.
        num = num / 10;      // num /= 10 - тоже самое.
    }
    
    return sum;
}
int n = 234;
int result = FindSumOfDigits(234);
Console.WriteLine($"Сумма цифр в числе {n} равна {result}");
*/

/*Задача2
int Summa(int a)
{
    int result = 0;
    int count = 1;
    while (count <= a)
    {
       result = result + count;
       count ++;
    }

    return result;
}
Console.WriteLine("Enter your number: ");
int num = Convert.ToInt32(Console.RedLine());
Console.WriteLine("Sum is: " + Summa(num));
*/

/*Задача3
int Fact(int a)
{
    int result = 1;
    int count = 1;
    while (count <= a)
    {
       result = result * count;
       count ++;
    }

    return result;
}
Console.WriteLine("Enter your number: ");
int num = Convert.ToInt32(Console.RedLine());
Console.WriteLine("Factorial is: " + Fact(num));
*/

/*Задача4
void Count(int a)
{
    int counter = 0;
    while (a > 0)
    {
        counter = counter + 1;
        a = a / 10;
    }
    Console.WriteLine(counter);
}
 Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

Count(a);
*/

/*Задача6
int size = 8;
int [] array =new int [size]; // {1, 2, 3};

for(int i = 0; i < size; i++)
{
   array [i]=new Random().Next(0, 2);
}

for(int i =0; i < size; i++)
{
    Console.Write(array[i] + " ");
}
*/
