// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Random rnd = new Random();
// int count_arr = rnd.Next(5, 10); //В условии не указана длинна массива по этому взял рандом от 5 до 10
// int[] arr = new int[count_arr];
// int num = 0;
// while (num < arr.Length)
// {
//     int count_num = rnd.Next(100,999);
//     arr[num] = count_num;
//     num++;
// }
// Console.WriteLine("Это сам массив (для примера)");
// for(int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]} ");
// }
// int j = 0;
// int count = 0;
// while (j < arr.Length)
// {
//     if ((arr[j]%2) == 0)count++;
//     j++;
// }
// Console.WriteLine($"-> {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Random rnd = new Random();
// int [] arr = new int[4];
// int num = 0;
// while(num < arr.Length)
// {
//     int count_num = rnd.Next(-99, 99);
//     arr[num] = count_num;
//     num++;
// }
// for(int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]} ");
// }
// int sum = 0;
// int j = 1;
// while(j < arr.Length)
// {
//     sum = sum + arr[j];
//     j = j + 2;
// }
// Console.WriteLine($"-> {sum}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Random rnd = new Random();
int [] arr = new int [5];
int num = 0;
int min = 0;
int max = 0;
int j = 0;
while (num < arr.Length)
{
    int count_num =rnd.Next(-10,10); 
    arr[num] = count_num;
    num++;
}
for (int i=0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
for (int i = 0; i < arr.Length; i++)
{
    if(arr[j] < arr[i])
    {
        min = arr[j];
    }
    else
    {
        min = arr[i];
        j = i;   
    }
}
for (int i = 0; i < arr.Length; i++)
{
    if (arr[j]>arr[i])
    {
        max = arr[j];
    }
    else
    {
        max = arr[i];
        j=i;
    }
}
int number = max - min;
Console.WriteLine($"-> {number}");