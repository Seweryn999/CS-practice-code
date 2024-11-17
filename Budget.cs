using System;
using System.Security.Cryptography.X509Certificates;

public class TestDwa
{

   static void budget()
{
        while (true)
        {
    {
        Console.WriteLine("-----Wybierz opcje-----");
        Console.WriteLine("1. Podaj przychód");
        Console.WriteLine("2. Podaj wydatki");
        Console.WriteLine("3. Pokaż rozliczenie");
        Console.WriteLine("Wybierz opcje (1, 2, 3): ");
        
        string op = Console.ReadLine();
        
    switch(op) 
    {
        case "1":
        przychod();
        break;

        case "2":
        wydatki();
        break;

        case "2":
        rozliczenie();
        break;
    }
     static void przychod()
{
Console.WriteLine("Podaj przychód: ");
string przychod = Console.ReadLine();
Console.WriteLine($"Twój przychód wynosi: {przychod}");
 }
    }
    }
    }
    }
