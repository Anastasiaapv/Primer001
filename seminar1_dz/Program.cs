//*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//Console.Clear();
//Console.WriteLine("Введите число: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int number2 = int.Parse(Console.ReadLine());
//if (number1>number2)
//{
//    Console.WriteLine($"Число {number1} больше чем {number2}");
////}
//else
//{
   // if (number2>number1)
    //{
    //    Console.WriteLine($"Число {number2} больше чем {number1}");
    //}
    //else 
    //{
    //    Console.WriteLine($"Число {number1} равно {number2}");
    //}
//}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Console.Clear();
//Console.WriteLine("Введите первое число: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int number2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите третье число: ");
//int number3 = int.Parse(Console.ReadLine());
//int max = number1;
//if (number1>max) max = number1;
//if (number2>max) max = number2;
//if (number3>max) max = number3;
//Console.Write ("max= ");
//Console.WriteLine(max);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//Console.Clear();
//Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//int new_var = number % 2;
//if (new_var == 0)
//{
 //   Console.WriteLine($"Число {number} чётное");
//}
//else
//{
//    Console.WriteLine($"Число {number} нечётное");
//}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
int count=1;
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
while (((count % 2) == 0))
// count = count + (number-2);
{
  
    Console.Write(count + " ");
    count +=2;
   
}


// for (int x = 1; x < number; x++)       
// if (x%2==0)            
// Console.WriteLine(x);








// count = count + (number-2);
// while (( (count % 2) == 0))
// {
//    count +=2;
//    Console.Write(count + " ");
// }

// {
//    count +=1;
//    Console.Write("");
// }


//count = count + (number-2);
//while (( (count % 2) == 0))
//{
  //  count +=2;
   // Console.Write(count + " ");
//}
