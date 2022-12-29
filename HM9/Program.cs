// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");

PrintNumber(8);
void PrintNumber (int N) {
    if (N>0) {
        Console.Write(N+","+" ");
        N--;
        PrintNumber(N);
    } else {
        return;
    }
}
Console.WriteLine();
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
int sum=0;
int result = SumInInterval(1, 15);
Console.WriteLine($"Резуьтат работы функции: {result}");


int SumInInterval(int a, int b) {
    
    if(a<=b) {
sum+=a;
a++;
SumInInterval(a, b);
    } else {
        return sum;
    }
   
 return sum;
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine();
Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии.");
int ResultAccerman=Accerman (2, 3);
int ResultAccerman1=Accerman (3, 2);
Console.WriteLine($"Результат работы функции Акермана  m = 2, n = 3 -> A(m,n): {ResultAccerman}");
Console.WriteLine($"Результат работы функции Акермана  m = 3, n = 2 -> A(m,n): {ResultAccerman1}");
int Accerman (int n, int m) {
if (n == 0){
     return m + 1;
}
if (n != 0 && m == 0) {
return Accerman(n - 1, 1);
}
if (n > 0 && m > 0) { 
    return Accerman(n - 1, Accerman(n, m - 1));
}
return Accerman(n,m); 
}  


                
            
