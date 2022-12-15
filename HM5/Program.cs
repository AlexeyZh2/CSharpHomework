// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] newArray=CreateArrey(10,100,999);
PrintArray(newArray);
CountEvenNumber(newArray);

int [] CreateArrey (int size, int min, int max) {
    int[] newArray = new int [size];
    Random random=new Random();
    for(int i=0; i<=size-1; i++) {
newArray[i]=random.Next(min,max+1);
    }
return newArray;
}

int CountEvenNumber (int[] arr) {
    int evenNumber =0;
    for (int i =0; i<=arr.Length-1; i++)
    if (arr[i]%2==0) evenNumber++;
    Console.WriteLine($"Количество четных чисел в массиве {evenNumber}");
    return  evenNumber;
}
void PrintArray (int[] array) {
    string str=string.Join(", ", array);
    Console.WriteLine($"Наш сгенерирванный массив: [{str}]");
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.WriteLine();
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

int[] Array1=CreateArrey(6,-10,10);
PrintArray(Array1);
SumAllElementsOnOddPosition(Array1);

int SumAllElementsOnOddPosition (int [] arr) {
    int sum=0;
    for(int i=0; i<=arr.Length-1; i++) {
        if(i%2 != 0) sum+=arr[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях - {sum}");
    return sum;
};

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine();
Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
int[] Array2=CreateArrey(6,10,1000);
PrintArray(Array2);
DifferenceMaxMin(Array2);
int DifferenceMaxMin (int [] arr) {
    int max = arr[0];
    int min =arr[0];
    int difference=0;
    for (int i=0; i<=arr.Length-2; i++) {
        if (arr[i]>max) {
            max=arr[i];
        }
        if (arr[i]<min) {
            min=arr[i];
        }
        

    }
    Console.WriteLine(max);
    Console.WriteLine(min);
    difference=max-min;
        Console.WriteLine($"Разница между максимальным и минимальным числом равна {difference}");
return difference;
}


