// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите число м: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] nums = new double[m, n];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = new Random().Next(1, 100);
        Console.Write($"{nums[i, j]} ");
    }
    Console.WriteLine();
}



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите число м: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];
Console.Write("Введите позицию строки: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());
void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = new Random().Next(0, 5);
Console.Write($"{randomArray[i,j]} ");
}
Console.WriteLine();
}
}
mas(m,n);
if (m2<1 || n2<1)
Console.Write($"Позиции строк не могут быть отрицательными");
else if (m2 <= m+1 && n2 <= n+1)
Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]} ");
else Console.Write($"Такого элемента нет в массиве");



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите число м: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m, n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
matrix[i,j] = rand.Next(1,9);
Console.Write($"{matrix[i,j]} ");
}
Console.WriteLine();
}
}

void arif(int m, int n)
{
Console.Write($"Среднее арифметическое каждого столбца: ");
int i,j;
Random rand = new Random();
for (j = 0; j < n; j++)
{
double sum = 0;
for (i = 0; i < m; i++)
{
sum = sum + matrix[i,j];
}
Console.Write($"{sum/(i):F1}; ");
}
}
mas(m,n);
arif(m,n);