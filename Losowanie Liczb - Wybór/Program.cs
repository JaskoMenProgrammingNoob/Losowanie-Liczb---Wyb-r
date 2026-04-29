using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Random los = new Random();
        int losowa = 0;
        
        double suma = 0;
        double max = 0;
        double min = 0;
        Console.WriteLine("Wybierz ilość losowanych liczb od 2 do 5");
        
        int n = int.Parse(Console.ReadLine());
        
       
        
            switch(n)
            {
                case 2: n = 2; Console.WriteLine("Wybrałeś losowanie 2 liczb.");
                
                    break;
                    case 3: n = 3; Console.WriteLine("Wybrałeś losowanie 3 liczb.");
                    break;
                    case 4: n = 4; Console.WriteLine("Wybrałeś losowanie 4 liczb.");
                    break;
                    case 5: n = 5; Console.WriteLine("Wybrałeś losowanie 5 liczb.");
                    break;
                default: Console.WriteLine("Nieprawidłowy wybór zakresu liczb");
                    break;

            }
        

        if (n >= 2 && n <= 5)
        {
            for (int i = 1; i <= n; i++)
            {

                losowa = los.Next(0, 100);
                Console.WriteLine($"Wylosowane liczby to: {losowa}");
                suma += losowa;
                if (i == 1)
                {
                    max = losowa;
                    min = losowa;
                }
                else
                {
                    if (losowa > max)
                    {
                        max = losowa;
                    }
                    if (losowa < min)
                    {
                        min = losowa;
                    }
                }
            }
            double srednia = suma / n;
            /* Console.WriteLine($"test sumy {suma}"); */
            Console.WriteLine($"Średnia wylosowanych liczb to: {srednia:#.##}");
            Console.WriteLine($"Wartość maksymalna wylosowanych liczb to: {max}");
            Console.WriteLine($"Wartośc minimalna wylosowanych liczb to: {min}");
        }
        

    }
    
}
