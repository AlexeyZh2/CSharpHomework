// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

// Console.WriteLine("Введите 6 целых любых чисел");
// Console.Write("Введите число 1: ");
// int num1= int.Parse(Console.ReadLine());

// Console.Write("Введите число 2: ");
// int num2=int.Parse(Console.ReadLine());

// Console.Write("Введите число 3: ");
// int num3=int.Parse(Console.ReadLine());

// Console.Write("Введите число 4: ");
// int num4=int.Parse(Console.ReadLine());

// Console.Write("Введите число 5: ");
// int num5=int.Parse(Console.ReadLine());

// Console.Write("Введите число 6: ");
// int num6=int.Parse(Console.ReadLine());

//  int[] newArray = {num1, num2, num3, num4, num5, num6};
//  PrintArray (newArray);

// int AmoutMoreNull (int [] arr) {
// int count = 0;
//   for (int i=0; i<=arr.Length-1; i++) {
//     if (arr[i] >0) count++;
//   }
    
//  return count;
// };
// void PrintArray (int[] array) {
//     string str=string.Join(", ", array);
//     Console.WriteLine($"Наш сгенерирванный массив: [{str}]");
// };
// int result = AmoutMoreNull (newArray);
// Console.WriteLine($"Количество чисел больше 0: {result}");
//Вариант 2.
//  Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
// Console.Write("Сообщите сколько чисел вы хотите ввести: ");
// int M= int.Parse(Console.ReadLine());
// int[] newArray = new int [M];
// for (int i=0; i<=M-1; i++) {
//      Console.Write("Введите число: ");
//      int num = int.Parse(Console.ReadLine());
// newArray[i]= num; 
// };
// PrintArray(newArray);
//  void PrintArray (int[] array) {
//     string str=string.Join(", ", array);
//     Console.WriteLine($"Наш сгенерирванный массив: [{str}]");
// };


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//k1 и k2 коэфициент наклона
// Console.WriteLine("Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем..");

// Console.WriteLine("");
// Console.Write("Введите коэффициент k1: ");
// int k1= int.Parse(Console.ReadLine());

// Console.Write("Введите число b1: ");
// int b1=int.Parse(Console.ReadLine());

// Console.Write("Введите коэффициент к2: ");
// int k2=int.Parse(Console.ReadLine());

// Console.Write("Введите число b2: ");
// int b2=int.Parse(Console.ReadLine());

// double [] Result2=InterseptionPoints(k1, b1, k2, b2);

// double [] InterseptionPoints (int a, int b, int c, int d ) {
//     double [] pointCoordinates= new double [2];
//     double X;
//     double Y;
//     if (a==c) {

//         Console.WriteLine("Эти прямые не пересекаются!!!");
//         pointCoordinates[0]=0;
//         pointCoordinates[1]=0;
//         return pointCoordinates;
//     } else {
//         X=(b2-b1)/(a-c);
//         Y=(a*X)+b1;
//         pointCoordinates[0]=X;
//         pointCoordinates[1]=Y;
//         return pointCoordinates;
//     }

// }

// double [] ResultPoints = InterseptionPoints(k1, b1, k2, b2);
// PrintArrayPoints(ResultPoints);
// void PrintArrayPoints (double[] array) {
//     string str=string.Join(", ", array);
//     Console.WriteLine($"Координаты точки пересечения: ({str})");
// };


