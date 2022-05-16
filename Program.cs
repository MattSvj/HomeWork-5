//Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
/*
int Stepen(int a, int b)
{
    int ans = 1;
    for(int i = 0; i < b; i++)
        {
            ans *= a;
        }        
    return ans;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Stepen(a, b));
*/

//Задача 2: Напишите программу, 
//которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Summa(int a)
{   
    int d;
    int sum = 0;
    for(int i = 0; i < a;)
        {
            d = a % 10;
            sum += d;
            a /= 10;
        }        
    return sum;
}

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa(a));
*/

//Задача 3: Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран.
int size = 8;
int[] array = new int[size];
for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1, 100000);
}
Console.WriteLine(string.Join(" ", array));
