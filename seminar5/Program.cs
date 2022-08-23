//Задача 31. Задайте масиив из 12 элементов
//заполненных в случайными числами из промежутка -9,9
// найти сумму отрицательных чисел и сумму положительных
// Метод который возвращает масиив заполненный случ числами промежутка -9 и 9
// int[] array = GetArray(12,-9,9);
// Console.WriteLine (String.Join(",", array));
// Console.WriteLine ($"Сумма положит цифр = {GetPositiveSumm(array)}");
// Console.WriteLine ($"Сумма отриц цифр = {GetNegativeSumm(array)}");

// int []GetArray (int count, int minValue, int maxValue)
// {
//     int []array = new int [count];
//     for (int i=0;i<count;i++)
//     {
//       array[i]= new Random().Next(minValue,maxValue+1);
//     }
//     return array;
// }
// //получить сумму отриц значений

// int GetNegativeSumm(int[]arr)
// {
//     int sum = 0;
//     for (int i =0; i< arr.Length;i++)
//     {
//         if (arr[i]<0)
//         {
//             sum+=arr[i];
//         }
//     }
//     return sum;
// }

// //получить сумму + значений

// int GetPositiveSumm(int[]arr)
// {
//     int sum = 0;
//     for (int i =0; i< arr.Length;i++)
//     {
//         if (arr[i]>0)
//         {
//             sum+=arr[i];
//         }
//     }
//     return sum;
// }

//Задача 32 Напишите программу где отриц элементы массива 
//заменяются таким же положит и наоборот
// int[] array = GetArray(12,-9,9);
// Console.WriteLine (String.Join(",", array));
// Console.WriteLine (String.Join(",", InvertArray (array)));

// int []GetArray (int count, int minValue, int maxValue)
// {
//     int []array = new int [count];
//     for (int i =0; i< arr.Length;i++)
//     {
//       array[i]= new Random().Next(minValue,maxValue+1);
//     }
//     return array;
// }

// int [] InvertArray (int []arr)
// {
//   for (int i=0;i<count;i++)
//   {
//     arr [i]*=-1;
//   }
  
//       return arr;
// }
//Задача 33 Задайте массив. Напишите программу которая 
//определяет есть ли искомое число в масииве



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// int[]array = GetArray (4);
// int x=100;
// for(int i=0; i< array.Length ; i++)
// {
//     Console.Write("{0} ",array[i]);
// }
// int Cislo = GetCislo (x);
// Console.WriteLine($"в этом массиве четных чисел {Cislo}");
// int GetCislo (int x)
// {
//     var result1 = array.Count(x => x % 2 == 0);
//          return result1;
// }
// int[]GetArray(int size)
// {
//     int[]arr= new int [size];
//     for ( int i =0;i <size; i++)
//     {
//         arr[i] = new Random().Next(1000);
//     }
//     return arr;
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// int[]array = GetArray (6);
// for(int i=0; i<array.Length ; i++)
// {
//     Console.Write("{0} ",array[i]);
// }
// var odd = array.Where((element, index) => index % 2 != 0);
// Console.WriteLine("Нечётные. Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());
// int[]GetArray(int size)
// {
//     var array = new int[6];
//             Random rnd = new Random();
//             for(int i = 0; i < array.Length; i++)
//             {
//                 array[i] = rnd.Next(-10, 10);
//              }
//     return array;
// }



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
            double max,min;
            double[] array = { 3,7,22,2,78 };
            double[] newarray={0};
            Console.Write("Массив:", array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Максимальное число массива {max}");
            min = max;
            for (int i = 0; i < array.Length; i++ )
            {
                min=(array[i]<min)?array[i]:min;
            }
            Console.WriteLine($"Минимальное число массива {min}");
            Console.WriteLine ($"{max}-{min}={max-min}");
            
            
//             double[] FillSourceArray(int size)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().NextDouble() * 100;
//     }
//     return array;
// }

//     double[]array= new double[]{3,7,22,2,78};
//     double max = array[0],min = max;
//     for (int i = 0; i < array.Length; i++ )
//     {
//         max= (array[i]>max)?array[i]:max;
//         min= (array[i]<min)?array[i]:min;
//         Console.Write ("{0} ",array[i]);;
//     }
// Console.WriteLine ($"\n{max}-{min}={max-min}");