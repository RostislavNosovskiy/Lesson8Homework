/*** Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
Console.Clear();
int [,] SpiralMatrix (int startnum){
int [,] result = new int [4,4];
int x = 0;
int y = 0;
result[x,y]=startnum;
   while (y<3){
        startnum++;
        y++;
        result[x,y] = startnum;
    }
       while (x<3){
        startnum++;
        x++;
        result[x,y] = startnum;
       }
        while (y>0){
        startnum++;
        y--;
        result[x,y] = startnum;
}
while (result [x-1,y] ==0){
    startnum++;
    x--;
    result[x,y] = startnum;
}
while (result [x,y+1] ==0){
    startnum++;
    y++;
    result[x,y] = startnum;
}
while (result [x+1,y] ==0){
    startnum++;
    x++;
    result[x,y] = startnum;
}
while (result [x,y-1] ==0){
    startnum++;
    y--;
    result[x,y] = startnum;
}

return result;
}
void PrintMatrix (int [,] matrix){
    for (int i =0; i<matrix.GetLength(0); i++){
        Console.WriteLine();
    for (int j =0; j<matrix.GetLength(1); j++){
        if (matrix[i,j] <10)
        Console.Write($"0{matrix[i,j]} ");
        else Console.Write($"{matrix[i,j]} ");
    }
    }
}
PrintMatrix(SpiralMatrix(1));
