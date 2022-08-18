//Задача 24 вводим число и находим сумму всех его цифр

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// // Console.WriteLine(GetSum(num));

// string str = num.ToString();   //преобразовыевает в строку
// Console.WriteLine(str);

// int GetSum(int number)
// {
//     int sum =0;
//     while (number>0)
//     {
//         sum+=number%10;
//         number /=10;
//     }
//     return sum;
// }


//Задача 26 принимает на вход число и выдает количество цифр в числе
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int count=0;
// while(number > 0)
// {
//         count = count + 1;
//         number = number / 10;
// }
//    Console.Write($"Количество цифр равно:{count}");
   //или
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(GetCount(num));

// int GetCount(int number)
// {
//     int count =0;
//     while (number>0)
//     {
//         count++;
//         number /=10;
//     }
//     return count;
// }
//Задача 28 принимает на вход число Н и выдает произведение чисел от 1 до Н

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int GetMultiply(int number)
// {
//     int result = 1;
//     for(int i = 1; i <= number;i++)
//     {
//         result*=i;
//     }
//     return result;
// }

// Console.WriteLine(GetMultiply(num));

//Задача 30 выводит массив из 8 эл-тов заполненный нулями и еденицами в случайном порядке
// Console.Clear();
// int[]array = GetBinaryArray (8);
//       Console.Write("Массив из 8 элементов: ");
// for(int i=0; i< array.Length ; i++)
// {
//     Console.Write(array[i]);
// }

// int[]GetBinaryArray(int size)
// {
//     int[]arr= new int [size];
//     for ( int i =0; i <size; i++)
//     {
//         arr[i] = new Random().Next(2);
//     }
//     return arr;
// }

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
 
// Console.WriteLine("Введите первое число: ");
// int numberA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine());

// int GetStepen(int numberA, int numberB)
// {
//     int result = 1;
//     for(int i = 1; i <= numberB;i++)
//     {
//         result=result * numberA;
//     }
//     return result;
// }
// int Stepen = GetStepen(numberA,numberB);

// Console.WriteLine(Stepen);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int GetSum(int num)
// {
//     int counter = Convert.ToString(num).Length;
//     int next=0;
//     int result = 0;
//     for(int i = 0; i<counter;i++)
//     {
//         next = num - num % 10;
//         result= result +(num -next);
//         num=num/10;
//     }
//     return result;
// }
// Console.WriteLine(GetSum(num));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[]array = GetArray (8);
    //    foreach (var elem in array)
    //         {
    //             Console.Write("{0}", elem);
    //         }
for(int i=0; i< array.Length ; i++)
{
    Console.Write("{0} ",array[i]);
}
int[]GetArray(int size)
{
    int[]arr= new int [size];
    for ( int i =0; i <size; i++)
    {
        arr[i] = new Random().Next(1000);
    }
    return arr;
}
