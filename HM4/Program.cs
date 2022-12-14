// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int PowMethod (int A, int B) {
    int result = 1;
    if (B==0) result=1;
    for (int i=1; i<=B; i++) {
result*=A;
    }
    return result;
}
Console.WriteLine(PowMethod(4, 4));
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
int SumAllDigits (int A) {
    int count = 0;
    int sum =0;
while (A > 1) {
     sum+=A%10;
     A=A/10;
    count++;
}

return sum;
};

Console.WriteLine(SumAllDigits (2084));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray (int A, int B, int C, int D, int E, int F, int G, int H) {
    int[] newArray = {A,B,C,D,E,F,G,H};
    Console.Write("Наш массив: "+"[" + newArray[0] + ", ");
    for (int i=1; i<7; i++) {
        Console.Write(newArray[i] + ", ");
    }
    Console.Write(newArray[7] + "] ");
 Console.WriteLine();   
return newArray;
};


CreateArray (1,2,3,4,5,6,7,8);


