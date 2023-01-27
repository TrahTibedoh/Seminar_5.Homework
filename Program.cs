//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] MyArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100,1000);  
}

int count = 0;
for (int m = 0; m < array.Length; m++)
if (array[m] % 2 == 0)
count++;

Console.WriteLine($"Всего {array.Length} трехзначных числа, {count} из них чётные.");
return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);

    Console.WriteLine();
}
Console.Write("Введите размер масива:");
int newArray = Convert.ToInt32(Console.ReadLine());
ShowArray(MyArray(newArray));

*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{   int sum = 0;
    int[] MyArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        MyArray[i] = new Random().Next(minValue, maxValue);
    }

    for (int z = 1; z < MyArray.Length; z+=2)
    sum = sum + MyArray[z];

    Console.WriteLine($"всего {MyArray.Length} чисел, сумма элементов на нечётных позициях = {sum}");
    
    return MyArray; 
}

 void ShowArray(int[] array)
 {
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
 }
    Console.Write("Ведите размер масива: ");
    int size = Convert.ToInt32(Console.ReadLine());
     Console.Write("Введите минимальный индекс масива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите максимальный индекс масива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[] newArray = CreateRandomArray(size, minValue, maxValue);
    ShowArray(newArray);
       */         



//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(double[] array) 
 {  
     for(int i = 0; i < array.Length; i++) 
        { 
             array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        } 
     return array;
 }

void ShowArray(double[] array)
 {
    for(int i = 0; i < array.Length; i++)
        {
             Console.WriteLine(array[i] +" ");
        }
        Console.WriteLine();
 }

    Console.Write("Введите размер масива: ");
    int size = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[size];
    CreateRandomArray(array);
    Console.WriteLine("Весь масив: ");
    ShowArray(array);
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];   
}
Console.WriteLine($"Всего в масиве {array.Length} чисел.Максимальное число = {max}, минимальное число = {min}.");
Console.WriteLine($"{max} - {min} = {max - min}. - Разница между максимальным и минимальным элементов массива");


*/



