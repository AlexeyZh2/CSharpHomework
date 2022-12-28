// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
try 
{
int m = readInt("Введите число m");
int n = readInt("Введите число n");
int [,] ourArray=create2DArrey (m, n);
Print2DArrey (ourArray);
Console.WriteLine();
int[,] result = SortRowArrayByDescending(ourArray);
Print2DArrey(result);
}
catch (Exception ex)
{
Console.WriteLine(ex.Message);
}



int readInt (string title) {
    Console.WriteLine(title);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);
    if (isParsed) {
        return number;
    }
    throw new Exception("Введены неверные данные");
}

int [,] create2DArrey (int a, int b) {
    int [,] array = new int [a,b];
    Random random = new Random();
    for (var i=0; i<array.GetLength(0); i++) {
        for (var j=0; j<array.GetLength(1); j++) {
            array [i,j] = random.Next(0, 10);
        }
    }
    return array;
};
void  Print2DArrey (int [,] array) {
    for (var i=0; i<array.GetLength(0); i++) {
        for (var j=0; j<array.GetLength(1); j++) {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }

}
int [,] SortRowArrayByDescending (int [,] array) {
for (var i=0; i<array.GetLength(0); i++) {
    for(var k=0; k<array.GetLength(1); k++) {
    for (var j=array.GetLength(1)-1; j>0; j--) {
int num=0;
if (array[i,j]>array[i,j-1]) {
    num = array[i,j-1];
    array[i,j-1]=array[i,j];
    array[i,j]=num;
    }
}
    }
}
return array;
};

void PrintArray (int [] array) {
    string str=string.Join(", ", array);
    Console.WriteLine($"Массив для проверки: [{str}]");
 };



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine();
Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
try 
{
int num1 = readInt("Введите число m");
int num2 = readInt("Введите число n");
int [,] ourArray1=create2DArrey (num1, num2);
Print2DArrey (ourArray1);
Console.WriteLine();
int stringNumber=RowArrayWithBiggestSum(ourArray1);
Console.WriteLine($"Номер строки с наименьшей суммой: {stringNumber}");
}
catch (Exception ex)
{
Console.WriteLine(ex.Message);
}

int RowArrayWithBiggestSum (int [,] array) {
    int stringNumber=0;
    int minsum=0;   
    int [] sum1= new int [array.GetLength(0)];
for (var i=0; i<array.GetLength(0); i++) {
    int sum=0;
    for (var j=0; j<array.GetLength(1); j++) {
sum+=array[i,j];
}
sum1[i]=sum;
    }
    PrintArray(sum1);
    minsum=sum1[1];
    
    for (int i=0; i<sum1.Length; i++) {
        if (sum1[i]<=minsum){
            minsum=sum1[i];  
}
    }
Console.WriteLine(minsum);
for (int i=0; i<sum1.Length; i++) {
    if (sum1[i]==minsum) {
        stringNumber=i+1;
    }
 }
    return stringNumber;
}



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine();
Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");


int num3 = 2;
int num4 = 2;

int [,] ourArray2=create2DArrey (num3, num4);

int [,] ourArray3=create2DArrey (num3, num4);
Console.WriteLine("Матрица 1");
Print2DArrey (ourArray2);
Console.WriteLine("Матрица 2");
Print2DArrey (ourArray3);
Console.WriteLine();
int [,] resultMatrix=MultiplicationMatrix(ourArray2, ourArray3);
Console.WriteLine("Резуьтат умножения матриц");
Print2DArrey (resultMatrix);




int [,] MultiplicationMatrix (int [,] array1, int [,] array2) {
    int[,] result=new int[2,2];
    result[0,0]= array1[0,0]*array2[0,0]+array1[0,1]*array2[1,0];
     result[0,1]= array1[0,0]*array2[0,1]+array1[0,1]*array2[1,1];
      result[1,0]= array1[1,0]*array2[1,0]+array1[1,1]*array2[1,0];
       result[1,1]= array1[1,0]*array2[0,1]+array1[1,1]*array2[1,1];
    
    return result;
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine();
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента..");


int num5 = readInt("Введите число a");
int num6 = readInt("Введите число b");
int num7=readInt("Введите число d");
int [,,] result3D=create3DArray(num5, num6,num7);
Print3DArray(result3D);
int [,,] create3DArray (int a, int b, int c) {
    int count=0;
int [,,] array = new int [a,b,c];
int [] auxilaryArray= new int [a*b*c];
Random random = new Random();
for (int x = 0; x < a; x++){    
    for (int y = 0; y < b; y++){
        for (int z = 0; z < c; z++){
             int number=random.Next(0, 30);
             if (auxilaryArray.Contains(number)) {
                number=random.Next(0, 30);
             } else {
             auxilaryArray[count]=number;
                    array[x, y, z] = number;
                    count++;
             }    
                  
                                }
                        }
                    }
                    Console.WriteLine(count);
                    return array;
                 }
                  
                             
                    



void  Print3DArray (int [,,] array) {
    for (var i=0; i<array.GetLength(0); i++) {
        for (var j=0; j<array.GetLength(1); j++) {
            for (var k=0; k<array.GetLength(2); k++) {
                Console.Write(array[i,j,k]+$"({i},{j},{k})"+" ");
        }
    }

}
}
    

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.WriteLine();
Console.WriteLine("Программа, которая заполнит спирально массив 4 на 4.");
int [,] resultSpiral=addNumberInArrayBySpiral();
Print2DArrey (resultSpiral);

int [,] addNumberInArrayBySpiral () {
    int [,] arraySpiral=new int [4,4];
    int num=1;
    arraySpiral[0,0]=1;
    for (var i=0; i<1; i++) {
        for(var j=1; j<4; j++) {
            arraySpiral[i,j]=arraySpiral[i,j-1]+1;
        }
    }
    for(var j=3; j<4; j++) {
    for (var i=1; i<4; i++) {
        
            arraySpiral[i,j]=arraySpiral[i-1,j]+1;
        }
    }
    for (var i=3; i<4; i++) {
     for(var j=2; j>-1; j--) {
            arraySpiral[i,j]=arraySpiral[i,j+1]+1;
        }
    }
    for (var j=0; j<1; j++) {
        for (var i=2; i>0; i--) {
arraySpiral[i,j]=arraySpiral[i+1,j] +1;
        }

    }
     for (var i=1; i<2; i++) {
     for(var j=1; j<3; j++) {
            arraySpiral[i,j]=arraySpiral[i,j-1]+1;
        }
    }
     for (var j=2; j<3; j++) {
        for (var i=2; i<3; i++) {
arraySpiral[i,j]=arraySpiral[i-1,j] +1;
        }

    }
    for (var i=2; i<3; i++) {
    for (var j=1; j>0; j--) {
        
arraySpiral[i,j]=arraySpiral[i,j+1] +1;
        }
    }    
    return arraySpiral;
}
