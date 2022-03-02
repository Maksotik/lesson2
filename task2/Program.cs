// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

Random rnd = new Random();
    int number = rnd.Next( 100, 1000 );
Console.WriteLine( "Сгенерированное число {0}", number );

    int a = number/100;
    int b = number%10;

Console.WriteLine("Результат---> {0}{1}", a , b);