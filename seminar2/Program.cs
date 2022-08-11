// Задача 1
// int num = new Random ().Next (10,100);
// int a1 = num / 10;
// int a2 = num % 10;

// int max = a1;
// if (max < a2)
// {
//     max =a2;
// }
// Console.WriteLine ($"Первая цифра {a1}, вторая цифра {a2}");
// Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");

// int a=234;
// int a1=a/100;
// int a2=a%10;
// int rez=a1*10+a2;
// console.write($" rez={rez}"):


// Задача 2
// int num = new Random ().Next (100,1000);

// int result =(num / 100) * 10 + num %10;
// // int a1 = num / 100;
// // int a2 = num % 10;
// // int a3 = num / 100;
// // int a1=a/100;
// // int a2=a%10;
// // int rez=a1*10+a2;
// Console.WriteLine ($"число {num} ---> {result}");
// // ($"число {num}: первая цифра {a1}, вторая цифра {a2},третья цифра {a3}");

//Задача 3

// Console.WriteLine("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());
// if (number1%number2==0)
// {
//     Console.WriteLine ($"число {number1} кратно {number2}");
// }
// else 
// {
//     Console.WriteLine ($"число {number1} не кратно {number2} остаток {number1%number2}");
// }

// Задача 4
// Console.WriteLine("Введите первое число: ");
// int number = int.Parse(Console.ReadLine());
// int a = 23, b = 7;
// if (number%a==0 && number%b==0)
// {
//     Console.WriteLine ("Инстинно");
// }
// else
// {
//     Console.WriteLine ("Ложно");
// }

// Задача 4
// Console.WriteLine("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine());
// //int num = int Math.Pow (5,2)  математическая степень число в квадр
// if (number1*number1==number2 || number2*number2==number1)
// {
//     Console.WriteLine ($"это квадрат числа");
// }
// else
// {
//     Console.WriteLine ($"не квадрат");
// }



// Задача 10 ДЗ Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.WriteLine("Введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine());

// int a1 = num / 100;
// int a2 = (num/10)%10;
// int a3 = num % 10;

// Console.WriteLine ($"Вторая цифра  числа {num}: {a2}");






// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num>99)
{
     int a1 = num / 100;
     int a2 = (num/10)%10;
     int a3 = num % 10;
     Console.WriteLine ($"Третья цифра  числа {num}: {a3}");
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}

// var newnum = num.ToString();
// if(num > 99)
// {
//     Console.WriteLine ($"Третья цифра  числа {num}: {newnum[2]}");
// }
// else
// {
//     Console.WriteLine ("Третьей цифры нет");
// }


// int []array = {a1,a2,a3};
// int []num = num.ToString().ToArray();
// int a3 = num % 10;
// if(num > 1)
// {
    
//     Console.WriteLine ($"Третья цифра  числа {num}: {num.ToString()[2]}");
// }
// else
// {
//     Console.WriteLine ("Третьей цифры нет");
// }


// int a1 = num / 100;
// int a2 = (num/10)%10;
// int a3 = num % 10;
// if(a3 > 99)
// {
//     Console.WriteLine((n / 100) % 10);
// }
// if (a3<0)
// {
//     Console.WriteLine ($"Третья цифра  числа {num}: {a3}");
// }
// else
// {
//     Console.WriteLine ("Третьей цифры нет");
// }
// }
// else
// {
//     Console.WriteLine("Элемента нет");
// }


//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите число от 1 до 7: ");
// int num = int.Parse(Console.ReadLine());
// if ( num<7 && 0<num )
// {

//     if(num>5)
//     {
//     Console.WriteLine ("выходной");
//     }
//     else 
//    {
//     Console.WriteLine ("будний");
//    }
// }
// else
// {
//    Console.WriteLine ("не корректный ввод");
// }