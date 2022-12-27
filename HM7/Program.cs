// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
try 
{
int m = readInt("Введите число m");
int n = readInt("Введите число n");
int [,] ourArray=create2DArrey (m, n);
Print2DArrey (ourArray);
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
            array [i,j] = random.Next(-100, 100);
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


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
Console.WriteLine("Программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
int str = readInt("Введите число строк");
int stolb = readInt("Введите число столбцов");
int [,] ourArray2=create2DArrey (str, stolb);
Print2DArrey (ourArray2);
Console.Write("Введите номер строки: ");
int num1= int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int num2=int.Parse(Console.ReadLine());
int num3=elementByTwoNumber (num1, num2, ourArray2);
Console.WriteLine($"По этим координатам расположено число {num3}");


int elementByTwoNumber (int a, int b, int [,] array) {
    if (a<=array.GetLength(0) && b<=array.GetLength(1)) {
        return array[a-1,b-1];
    }
    throw new Exception("Такого числа в массиве нет");

}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
int str1 = readInt("Введите число строк");
int stolb1 = readInt("Введите число столбцов");
int [,] ourArray3=create2DArrey (str1, stolb1);
Print2DArrey (ourArray3);


double [] result=arithmeticMeanOfColumn (ourArray3);
PrintArray(result);


double [] arithmeticMeanOfColumn (int [,] array) {

    double [] arrayResult =  new double [array.GetLength(1)]; 
    for  (var i=0; i<array.GetLength(0); i++) {
        for  (var j=0; j<array.GetLength(1); j++) {
            arrayResult[j]+=array[i,j];
            

        }
    }  
    for (var i=0; i<arrayResult.Length; i++) {
        arrayResult[i]=arrayResult[i]/array.GetLength(0);
    }    
return arrayResult;
}
void PrintArray (double[] array) {
    string str=string.Join(", ", array);
    Console.WriteLine($"Массив состоит из средних арифметических каждого столюца: [{str}]");
 };
