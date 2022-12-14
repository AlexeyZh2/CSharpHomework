// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.Write("Введите пятизначное число: ");
string number1=Console.ReadLine();
 char[] number1Array = number1.ToCharArray();
 Console.WriteLine(number1Array);
string reverse = "";
    for (int i = number1Array.Length - 1; i > -1; i--)
    {
        reverse+=number1Array[i];
    }
    Console.WriteLine(reverse);
if (reverse==number1) Console.WriteLine($"Введенное число {number1} является полиандромом");
else Console.WriteLine($"Введенное {number1} число не является полиандромом");


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

//d = \sqrt{[(x_2 - x_1)^2 +(y_2 - y_1)^2 + (z_2 - z_1) ^ 2]}
double[] point1 = {3,6,8};
double[] point2 = {2,1,-7};
double lengthLine=Math.Sqrt(Math.Pow((point2[0]-point1[0]), 2) + Math.Pow((point2[1]-point1[1]), 2) + Math.Pow((point2[2]-point1[2]), 2));
Console.WriteLine($"Расстояние между точками равно {lengthLine}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("Введите число: ");
int num1=int.Parse(Console.ReadLine());
for (int i =1; i<=num1; i++) {
    Console.Write($"{i*i*i}  ");
}



