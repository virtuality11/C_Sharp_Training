using System;

public class DateTimee
{
    static void Main(string[] args)
    {
        // Atleast three values , year , months and day have to be passed otherwise if you try to print sth , it will show runtime exception
        DateTime dt2 = new DateTime(2001, 11 , 2 , 10 , 32 , 21 , 23);
        Console.WriteLine(dt2.Month);
        Console.WriteLine(dt2.Hour); 


    }
}