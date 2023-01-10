/*
Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет
*/

void FillArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
        for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(1,101);
		}

    }
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
        Console.Write($"[");
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
        Console.Write($"]");
	    Console.WriteLine();
	}
}

Random randomArraySize = new Random();
int[,] randomArray = new int[randomArraySize.Next(3, 11),randomArraySize.Next(3, 11)];
FillArray(randomArray);
PrintArray(randomArray);
Console.WriteLine("Enter the number of row");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
int m = Convert.ToInt32(Console.ReadLine());

try
{
    Console.WriteLine($"Element [{n},{m}] is: {randomArray[n,m]}");
}
catch(Exception)
{
    Console.WriteLine("This element is not exist!");
}