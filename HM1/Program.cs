// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Введите число 1: ");
int num1= int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2=int.Parse(Console.ReadLine());

 
    if (num1 > num2) {
        Console.WriteLine($"Число {num1} больше чем {num2}");
    } else {
       Console.WriteLine($"Число {num2} больше чем {num1}"); 
    };



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел");
Console.Write("Введите число 1: ");
int number1= int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2=int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3=int.Parse(Console.ReadLine());
if (number1>number2 && number1>number3) {
    int max = number1;
    Console.WriteLine($"Число {max} самое большое");
}
if (number2>number1 && number2>number3) {
    int max = number2;
    Console.WriteLine($"Число {max} самое большое");
} else {
    int max = number3;
    Console.WriteLine($"Число {max} самое большое");
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Программа, которая принимает на вход число и выдаёт, является ли число чётным");
Console.Write("Введите число 1: ");
int number4= int.Parse(Console.ReadLine());
if (number4%2==0) {
    Console.WriteLine($"Число {number4} является четным");
} else {
    Console.WriteLine($"Число {number4} является нечетным");
}



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа, которая принимает на вход число (N), а на выходе показывает все чётные числа от 1 до N");
Console.Write("Введите число: ");
int number5= int.Parse(Console.ReadLine());
int number6=2;
if (number6 == number5) {
    Console.WriteLine(number6);
}
if (number6<number5) {
    while (number6<=number5) {
        Console.WriteLine(number6);
        number6=number6+2;
    }
}


