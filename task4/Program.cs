// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер  дня недели- ");
    int N = int.Parse( Console.ReadLine() );

if( N==6 || N==7 ) 
    Console.WriteLine(" Выходной! ");
else

if( N>7 || N<1 )
    Console.WriteLine(" В неделе 7 дней!!! ");
else
    Console.WriteLine(" Рабочий день! ");
    

