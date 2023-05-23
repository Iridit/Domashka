// // Напишите программу
// Console.WriteLine("Введите число");
// string input = Console.ReadLine();
// int namber = Convert.ToInt32(input);
// int result = namber * namber;
// Console.WriteLine(result);

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите первое число");
// string input = Console.ReadLine();
// int namber1 = Convert.ToInt32(input);
// Console.WriteLine("Введите второе число");
// input = Console.ReadLine();
// int namber2 = Convert.ToInt32(input);
// if (namber1 == namber2*namber2)
// {Console.WriteLine("Yes");}
// else 
// {Console.WriteLine("No");}

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("Введите число");
// int input = Console.ReadLine();
// int namber1 = Convert.ToInt32(input);
// if 

// Console.WriteLine("Input a number:");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number == 1) Console.WriteLine("Monday");
// else if(number == 2) Console.WriteLine("Tuesday");
// else if(number == 3) Console.WriteLine("Wednesday");
// else if(number == 4) Console.WriteLine("Thursday");
// else if(number == 5) Console.WriteLine("Friday");
// else if(number == 6) Console.WriteLine("Saturday");
// else if(number == 7) Console.WriteLine("Sunday");
// else Console.WriteLine("Error");

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// switch (number)
// {
//     case 1:
//         Console.WriteLine("Monday");
//         break;
//     case 2:
//         Console.WriteLine("Tuesday");
//         break;
//     case 3:
//         Console.WriteLine("Wednesday");
//         break;
//     case 4:
//         Console.WriteLine("Thursday");
//         break;
//     case 5:
//         Console.WriteLine("Friday");
//         break;
//     case 6:
//         Console.WriteLine("Saturday");
//         break;
//     case 7:
//         Console.WriteLine("Sunday");
//         break;
//     default:
//         Console.WriteLine("Такого дня не существует");
//         break;
// }

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// Console.WriteLine("Input a number:");
// Console.Write("Введите число N: ");
//         int n = int.Parse(Console.ReadLine());
//         string result = "";
//         int last = Math.Abs(n);
//         for (int i = -last; i <= last; i++)
//         {
//             result += i.ToString();
//             if (i != last)
//             {
//                 result += ", ";
//             }
//         }
//         Console.WriteLine(result);

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// Console.WriteLine("ВВедите трехзначное число:");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number <= 999 && number > 99)
// Console.WriteLine(number % 10);
while (true)
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 0)
    {
        break;
    }
}

Console.WriteLine("Break");git remote add origin 



