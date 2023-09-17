// Задача 34



//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2



int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void Print(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}
int GetCount(int[] arr)
{
    int sumIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            sumIndex++;
        }
    
    }
    return sumIndex;
}

int[] arr = GetArray (5, 100, 999);
Print(arr);
int summa = GetCount(arr);
Console.WriteLine($"Количество четных чисел в массиве равно {summa}.");






//  Задача 36





//Задайте одномерный массив, заполненный случайными числами. 
//1Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void Print(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}
int GetSumma(int[] arr)
{
    int sumNumbers = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 1)
        {
            sumNumbers += arr[i];
        }
    }
    return sumNumbers;
}

int[] arr = GetArray(4, 1, 1000);
Print(arr);
int summa = GetSumma(arr);
Console.WriteLine($"Сумма нечетных чисел в массиве равна {summa}.");




//  Задача 38




//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] GetArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int index = 0; index < size; index++)
    {
        array[index] = rand.NextDouble() + rand.Next(min, max + 1);
    }
    return array;
}

void Print(double[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");

    }
    Console.WriteLine();
}
double GetMaxNumber(double[] arr)
{
    double maxinum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxinum)
        {
            maxinum = arr[i];
        }
    }
    return maxinum;
}

double GetMinNumber(double[] arr)
{
    double minnum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minnum)
        {
            minnum = arr[i];
        }
    }
    return minnum;
}


double[] arr = GetArray(4, -100, 100);
Print(arr);
double max = GetMaxNumber(arr);
double min = GetMinNumber(arr);
double difference = GetMaxNumber(arr) - (GetMinNumber(arr));
Console.WriteLine($"Разница максимального числа массива {max:0.000} и минимального числа массива {min:0.000} равна {difference:0.000}.");


