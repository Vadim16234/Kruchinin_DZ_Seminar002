// Задача 10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем
// 456 -> 5
// 782 -> 8
// 918 -> 1

// РЕШЕНИЕ:

// Console.WriteLine("Введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine());
// int num1 = num%100;
// int num2 = num1/10;
// Console.WriteLine($"Показывает второе число {num2} ");


// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)

// РЕШЕНИЕ

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int num1 = 999;
// int num2 = 9999;
// int numMin = 100;
// int numMax = 99999;
// if(number < numMin){
//     Console.WriteLine($"Число {number} не имеет третьей цифры ");
// }
// if(number > numMax){
//     Console.WriteLine($"Число {number} больше максимального значения ");
// }
// int number3 = 0;
// if(numMin <= number && number <= num1){
//     number3 = (number % 100) % 10;
//     Console.WriteLine($"Третье цифра в числе {number} является {number3}");
// }
// if(number > num1 && number <= num2){
//     number3 = (number % 100) / 10;
//     Console.WriteLine($"Третье цифра в числе {number} является {number3}");
// }
// if(number > num2 && number <= numMax){
//     number3 = (number % 1000) / 100;
//     Console.WriteLine($"Третье цифра в числе {number} является {number3}");
// }


// Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным. Обязательно сделать проверку на ввод чисел меньше 1 и больше 7

// РЕШЕНИЕ

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// if((num < 1) && (num > 7)){
//     Console.WriteLine("Это вообще не день недели");
// }

// switch (num){
//     case 1: Console.WriteLine("Понедельник");
//     break;
//      case 2: Console.WriteLine("Вторник");
//     break;
//      case 3: Console.WriteLine("Среда");
//     break;
//      case 4: Console.WriteLine("Четверг");
//     break;
//      case 5: Console.WriteLine("Пятница");
//     break;
//      case 6: Console.WriteLine("Суббота");
//     break;
//      case 7: Console.WriteLine("Воскресенье");
//     break;
//     default: Console.WriteLine("В неделе всего 7 дней");
//     break;
// }
// if((num == 6) || (num == 7)){
//     Console.WriteLine("Это выходной день!");
// }
