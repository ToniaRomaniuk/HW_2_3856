// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");

int number = int.Parse(Console.ReadLine());

if (number < 100 || number > 999)
{        
    Console.WriteLine($"{number} не трехзначное число");
}

else
{
    number = number / 10 % 10;
    Console.WriteLine(number);
}

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");

int number1 = int.Parse(Console.ReadLine());

if (number1 < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (number1 > 1000)
    {
        number1 = number1 / 10;
    }
    number1 = number1 % 10;
    Console.WriteLine(number1);

}


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7");

int number2 = int.Parse(Console.ReadLine());

if (number2 == 6 || number2 == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
