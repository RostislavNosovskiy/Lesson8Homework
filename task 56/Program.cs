/*** Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
Console.Clear();
int [,] Matrix (int n, int m, int min, int max){
    int [,] result = new int [n,m];
    for (int i =0; i<n; i++){
    for (int j =0; j<m; j++){
        result [i,j] = new Random().Next(min,max);
    }
    }
    return result;
}
void PrintMatrix (int [,] matrix){
    for (int i =0; i<matrix.GetLength(0); i++){
        Console.WriteLine();
    for (int j =0; j<matrix.GetLength(1); j++){
        Console.Write($"{matrix[i,j]} "); 
    }
    }
}
void LowLineIndex (int [,] array){
  int LowlineIndex = 1;
  int lineSum = 0;
  int LowlineSum = 0;
  for (int j = 0; j < array.GetLength(1); j++){
    LowlineSum +=array[0,j];
  }
for (int i = 0; i < array.GetLength(0); i++){
  for (int j = 0; j < array.GetLength(1); j++){
    lineSum +=array[i,j];
  }
  if ( LowlineSum > lineSum )
  {LowlineIndex = i+1;
  LowlineSum = lineSum;
  }
  lineSum = 0;
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов -> {LowlineIndex}");
}
Console.WriteLine("Введите число строк");
 int n = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите число столбцов");
 int m = int.Parse(Console.ReadLine());
int [,] Array = Matrix(n,m,0,10);
PrintMatrix(Array);
Console.WriteLine();
LowLineIndex(Array);