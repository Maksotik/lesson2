// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число- ");
    int number = int.Parse( Console.ReadLine() );
    int a = (number/10)%10;
Console.WriteLine( "Второе число---> {0}", a );



