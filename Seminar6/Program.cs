/*
int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length -1, i = 0;
    
    while(i < j) // первый способ
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
    }
/*
    for(int i = 0; i < array.Length / 2; i++; j--) // второй способ
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    return array;
}
*/
/*
int[] myArray = {2, 4, 6, 8, 10, 12};

myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
} 
*/
/*Задача2
void Triangle(int a, int b, int c)
{
    if(a +b > c && b + c > a && c + a > b)
    Console.WriteLine("Такой треугольник возможен");
    
    else Console.WriteLine("Такой треугольник не возможен");  
}

int a = 3;
int b = 5;
int c = 10;
Triangle(a, b, c);
*/

/*Задача3
// f(n) = f(n-1) + f(n-2) - число Фибоначчи
void Fibonacci(int n)
{
    int[] array = new int [n];
    array[0] = 0;
    array[1] = 1;
    Console.Write(array[0] + " " + array[1] + " ");
    for(int i = 2; i < n; i++)
    {
        array[i] = array [i -1] + array [i -2];
         Console.Write(array[i] + " ");
    }

}
 
 int n = 7;
 Fibonacci(n);
 */

/*Задача4
 string BinaryNumber(int num)
 {
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
 }
 Console.WriteLine(BinaryNumber(10));
 */