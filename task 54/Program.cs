/** Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 22*/
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
int [,] ChangeMatrix (int [,] array){
     int max =  array[0,0];
     for (int k =0; k<array.GetLength(0); k++)
for (int i = 0; i< array.GetLength(1)-1; i++){
    for (int j = i+1; j< array.GetLength(1);j++){
     if (array[k,i] < array[k,j]){
       max =  array[k,i];
       array[k,i] = array[k,j];
       array[k,j] = max;
     }
    }
}
    return array;}

Console.WriteLine("Введите число строк");
 int n = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите число столбцов");
 int m = int.Parse(Console.ReadLine());
int [,] Array = Matrix(n,m,0,10);

PrintMatrix(Array);
Console.WriteLine();
PrintMatrix(ChangeMatrix(Array));



