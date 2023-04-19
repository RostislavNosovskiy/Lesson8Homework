/*** Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
int [,] Matrix (int n, int m, int min, int max){
    int [,] result = new int [n,m];
    for (int i =0; i<n; i++){
    for (int j =0; j<m; j++){
        result [i,j] = new Random().Next(min,max);
    }
    }
    return result;
}
int [,] ProduckOfMatrix (int [,] Matrix1, int [,] Matrix2){
    int [,] result = new int [Matrix1.GetLength(0),Matrix2.GetLength(1)];
    for (int i = 0; i< result.GetLength(0); i++){
        for (int j = 0; j< result.GetLength(1); j++){
            for (int k = 0; k< Matrix2.GetLength(0); k++){
                    result [j,i] +=  (Matrix1[j,k]* Matrix2[k,i]);
                 }
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
Console.WriteLine("Введите число строк матрицы 1");
 int n = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите число столбцов матрицы 1");
 int m = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите число строк матрицы 2");
 int w = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите число столбцов матрицы 2");
 int z = int.Parse(Console.ReadLine());
int [,]Matrix1 =Matrix(n,m,0,10);
PrintMatrix(Matrix1);
Console.WriteLine();
int [,]Matrix2 =Matrix(w,z,0,10);
PrintMatrix(Matrix2);
Console.WriteLine();
if (Matrix1.GetLength(1) == Matrix2.GetLength(0))
PrintMatrix(ProduckOfMatrix(Matrix1,Matrix2));
else Console.WriteLine("Произведение матриц невозможно");