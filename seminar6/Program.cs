// Задача 39 программа которая выдает массив в потом его переворачивает


// задача 40 напишите программу, которая принимает на выход
// три чесла и проверет, может ли существовать треугольник со сторонами такой длиный
// Теорема о неравенстве треугольника: каждая сторона меньше суммы двух доругих
// Console.Clear();
// Console.WriteLine("Введите 1 число: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите 2 число: ");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите 3 число: ");
// int c = int.Parse(Console.ReadLine());
// if (CheckTriangle(a, b, c) == true && CheckTriangle(b, a, c) == true && CheckTriangle(c, a, b) == true)
// {
//     Console.WriteLine("Существует");
// }
// else
// {
//     Console.WriteLine("Не существует");
// }

// bool CheckTriangle (int a, int b, int c)
// {
//     if (a < b + c) return true;
//     else return false;
// }


       

// Задача 42 Напишите программу, которая будет преобразовывать десятич в двоич
// int x=12;
// string bin= Convert.ToString(x,2);
 
// Console.WriteLine(bin);

    
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"{DecimalToDouble(number)}");

// int DecimalToDouble (int number)
// {
//     int doubleNumber = 0;
//     for (int i = 0; number > 0; i++)
//     {
//         doubleNumber = (doubleNumber + number % 2) * 10;
//         number = number / 2;
//     }
//     return doubleNumber;
// }

// Задача 44 Не использую рекурсию, вывести первые Н чисел Фибоначчи.
// Console.WriteLine("До какого числа считать ряд Фибоначчи?");
// int number = Convert.ToInt32(Console.ReadLine());
// int num1 = 0;
// Console.Write("{0} ", num1);
// int num2 = 1;
// Console.Write("{0} ", num2);
// int sum = 0;
// while (number >= sum)
//             {
//                 sum = num1 + num2;
//                  Console.Write("{0} ", sum);
//                        num1 = num2;
//                         num2 = sum;                
//                 }
// Задача 45 Напишите программу которая будет 
// создавать копию заданноего массива с помощью поэлементного копирования
// int[] array = { 8, 10, 9, 4, 5 };

//         int[] copy = new int[array.Length];
//         Array.Copy(array, copy, array.Length);
     
//         Console.WriteLine(String.Join(", ", copy));
//         Console.WriteLine("Массив:", array);