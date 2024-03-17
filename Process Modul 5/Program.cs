using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");

        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");

        var deep = int.Parse(Console.ReadLine());

        
            Echo(str, deep);
        Console.ReadKey();
        
    }

    static void Echo(string saidword, int deep)
    {
        var modif = saidword;
    
            if (modif.Length > 2) 
        {
            modif = modif.Remove(0, 2);
        }
        Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." +  modif);
        if (deep > 1) 
        {
        Echo(modif, deep - 1);
        }
    }
    static int Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
            
            
    }
    private static int hhh(int N, byte pow)
    {
        Console.WriteLine("Введите число");
        var noom = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень");
        var naam = Convert.ToInt32(Console.ReadLine());
       
        if (naam == 0)
        {
            return 0;
        }
        if (naam == 1)
        {

            return noom;

        }
        return naam;

    }
    
}