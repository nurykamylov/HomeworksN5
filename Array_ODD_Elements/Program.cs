/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.Write("Type the length of array: ");
int a = int.Parse(Console.ReadLine()!);

int [] array = new int[a];

FillArray(a, array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("odd elements: " + OddElements(array) );

int [] FillArray( int a, int[] array)
{
   
    var rnd = new Random();
    for (int i = 0; i < a; i++)
    {
        array [i] = rnd.Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
        Console.Write(array[i] + " ");
   }
}


int OddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2  == 0 )
        {
            sum = sum + 1;
        }
       
    }
    return sum;
}
