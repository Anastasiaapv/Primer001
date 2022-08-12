// Write ("Введите Х: ");
// int х= int.Parse(ReadLine());

// Write ("Введите Y: ");
// int y= int.Parse(ReadLine());

// if (x>0 && y>0)
// Console.WriteLine("1");
// if (x>0 && y>0)
// Console.WriteLine("2");
// if (x>0 && y>0)
// Console.WriteLine("3");
// if (x>0 && y>0)
// Console.WriteLine("4");


// Console.WriteLine("Введите номер четверти: ");
// int num = int.Parse(Console.ReadLine());
// switch (num)
// {
//     case 1:
//     Console.WriteLine("X - положительный Y- положительный");
//     break;
//       case 2:
//     Console.WriteLine("X - отрицательный Y- положительный");
//     break;
//       case 3:
//     Console.WriteLine("X - отрицательный Y- отрицательный");
//     break;
//       case 4:
//     Console.WriteLine("X - положительный Y- отрицательный");
//     break;
//         default:
//         Console.Write("Неверный номер четверти");
//         break;
// }

// Console.WriteLine("Введите координаты точек");
// Console.WriteLine("Введите X первой точки: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y первой точки: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите X первой точки: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y первой точки: ");
// int y2 = int.Parse(Console.ReadLine());

// double c = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));

// Console.WriteLine($"c= {c:F3}");


// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// for (int x=1; x <= number; x++) 
// {
//     Console.WriteLine($"{x}*{x} = {x*x}");
// }        


// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// for (int x=1; x <= number; x++) 
// {
//     Console.WriteLine($"{x}*{x}*{x} = {x*x*x}");
// }   

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// Console.WriteLine("Введите координаты точек");
// Console.WriteLine("Введите X первой точки: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y первой точки: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Z первой точки: ");
// int z1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите X второй точки: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y второй точки: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Z второй точки: ");
// int z2 = int.Parse(Console.ReadLine());
// double c = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
// Console.WriteLine($"c= {c:F3}");


// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int temp = n;
int rev = 0;
while(n > 0)
{
    int dig = n % 10;
    rev = rev * 10 + dig;
    n = n / 10;
}
   if(temp == rev)
{
Console.WriteLine("Это палиндром!");
}
else
{
    Console.WriteLine("Это не палиндром!");
}

