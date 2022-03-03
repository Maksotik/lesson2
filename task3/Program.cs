// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число- ");
    string number = Console.ReadLine( );
    int N = int.Parse( number );

if( N >= 100 )
    Console.WriteLine("Третья цифра числа {0}- {1}", N, number[2]);

else
    Console.WriteLine(" Третьей цифры нет! ");
    
       