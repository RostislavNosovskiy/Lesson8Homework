/*** Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.Clear();
int [,,] matrix (int n, int m, int l, int min, int max){
    int [,,] result = new int [n,m,l];
    for (int i =0; i<n; i++){
        for (int j =0; j<m; j++){
           for (int k =0; k<l; k++){
    result[i,j,k] = new Random().Next(min,max);
    for (int a =0; a<i; a++){
        for (int b =0; b<j; b++){
          for (int c =0; c<k; c++){
           while ((result[i,j,k] == result[a,b,c]) && (result[a,b,c] >0) ) {
            result[i,j,k] = new Random().Next(min,max);
           }
          }  
        }
    }
    }
    }
    }
    return result;
}
void PrintMatrix (int [,,] matrix){
    for (int i =0; i<matrix.GetLength(0); i++){
        for (int j =0; j<matrix.GetLength(1); j++){
           for (int k =0; k<matrix.GetLength(2); k++)
           Console.WriteLine($"{matrix[i,j,k]} ({i},{j},{k})");
           }}
}
int [,,] Matrix = matrix(2,2,2,10,100);
PrintMatrix(Matrix);