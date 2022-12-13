// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.Write("Введите трёхзначное число: ");
int number1=int.Parse(Console.ReadLine());
int secondNumber = (number1/10) %10;
Console.WriteLine($"Второй символ введенного числа {secondNumber}");

// Задача 13:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Принимает на вход число и на выходе показывает третью цифру этого числа или говорит что его нет.");
Console.Write("Введите число: ");
int number2=int.Parse(Console.ReadLine());
int num2=number2;
int count = 0;
while (num2 > 1) {
     num2=num2/10;
    count++;
}
Console.WriteLine($"В введенном числе {count} символов");
if (count<3) Console.WriteLine($"Во введенном числе нет третьего символа!");
double denominator = Math.Pow(10, count-3);
   int thirdsimbol= (number2/Convert.ToInt32(denominator))%10;

Console.WriteLine($"Третий символ введенного числа {thirdsimbol}");



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Проверяет является ли день выходным");
Console.Write("Введите число: ");
int dayNumber=int.Parse(Console.ReadLine());
if (dayNumber>=1 && dayNumber<=5) {
    Console.WriteLine("Это рабочий день!");
}
if (dayNumber==6 || dayNumber == 7) {
    Console.WriteLine("Это выходной день!");
} 
if (dayNumber >7 || dayNumber<1) {
    Console.WriteLine("Число д. б. в интервале от 1 до 7!");
}