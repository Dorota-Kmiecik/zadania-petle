using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien_2_petle
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Zadanie 1");
            bool isPrime = true;
            int primeCounter = 0;
            for (int i = 2; i <= 100; i++)
            {
                isPrime = true;
                for (int j = 2; j <= 100; j++)
                {
                    if (i != j && i > j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeCounter++;
                }
            }
            Console.WriteLine($"Mamy tyle liczb piewszych:{primeCounter}. \n");
            Console.WriteLine();
            Console.WriteLine("Zadanie 2");
            Console.WriteLine();
            int k = 0;
            do
            {
                k++;
                if ( k % 2 == 0)
                {
                    Console.WriteLine($"Liczba to: {k}");
                }
            }
            while (k <= 1000);

            Console.WriteLine();
            Console.WriteLine("Zadanie 3");
            Console.WriteLine();

            int firstNumber = 0, SecondNumber = 1, nextNumber;
            Console.Write(firstNumber + " " +"\n"+ SecondNumber + " " + "\n");
            nextNumber = firstNumber + SecondNumber;

            for (int l = 2; nextNumber < 100; l++)
            {
                Console.Write(nextNumber + " " + "\n");
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
                nextNumber = firstNumber + SecondNumber;
            }

            Console.WriteLine();
            Console.WriteLine("Zadanie 4");
            Console.WriteLine();

            int counter = 0;
            Console.WriteLine("Podaj liczbe" + "\n");
            int counterMax = int.Parse(Console.ReadLine());           
            for (int m = 1; m <= counterMax; m++)
            {
                for (int n = 1; n <= m; n++)
                {
                    counter++;
                    Console.Write($"{counter} ");
                    if (counter == counterMax)
                    break;                    
                }
                if (counter == counterMax)
                break;
                Console.WriteLine();
            }

            // Drugie rozwiazanie: 
            Console.WriteLine();
            Console.WriteLine("Podaj maksymalna liczbe:");
            int counterMax2 = int.Parse(Console.ReadLine());
            int counter2 = 1;
            int level = 1;
            while (counter2 <= counterMax2)
            {
                for (int i = 1; i <= level; i++)
                {
                    if (counter2 <= counterMax2)
                    {
                        Console.Write($"{counter2} ");
                    }
                    counter2++;
                }
                level++;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Zadanie 5");
            Console.WriteLine();
            
            for (int o = 1; o <= 20; o++)
            {
                Console.WriteLine(o * o * o + "\n");
            }

            Console.WriteLine();
            Console.WriteLine("Zadanie 6");
            Console.WriteLine();
            
            decimal p;
            decimal value1 = 0;
            for (p = 1; p <= 20; p++)
            {
                value1 = value1 + 1 / p;
            }
            Console.WriteLine(value1);

            Console.WriteLine();
            Console.WriteLine("Zadanie 7");
            Console.WriteLine();
            
            Console.WriteLine("Podaj przekatna");
            int diagonal = int.Parse(Console.ReadLine());
            if (diagonal % 2 == 0)
            {
                int half1 = (diagonal / 2);
                for (int i = 1; i <= half1; i++)
                {
                    for (int j = i + 1; j <= half1; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 1; j <= 2 * i; j++)
                    {
                        Console.Write("* ");

                    }
                    Console.WriteLine();
                }
                for (int i = 1; i <= half1 - 1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = i; j <= half1; j++)
                    {
                        Console.Write("* ");
                    }
                    for (int j = i; j < half1 - 1; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                int half = (diagonal / 2) + 1;
                for (int i = 1; i <= half; i++)
                {
                    for (int j = i; j <= half - 1; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i < half; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = i; j < half; j++)
                    {
                        Console.Write("* ");
                    }
                    for (int j = i; j < half-1; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }

            // Piramida z liter: 
            //int k = 65; 
            // for (int i = 1; i <= 5; i++) 
            // {   
            //     for (int j = 1; j <= i; j++)
            //     {
            //         Console.Write((char)(j+64) + " ");
            //     }
            //     Console.WriteLine("\n");

            Console.WriteLine();
            Console.WriteLine("Zadanie 8");
            Console.WriteLine();

            Console.WriteLine("Podaj tekst do odwrocenia");
            string normalWritten = Console.ReadLine();
            string reverse = "";
            for (int z = normalWritten.Length - 1; z >= 0; z--)
            {
                reverse += normalWritten[z];
            }
            Console.WriteLine(reverse);

            Console.WriteLine();
            Console.WriteLine("Zadanie 9");
            Console.WriteLine();

            Console.WriteLine("Podaj liczbe");
            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine($"Liczba binarna to: {result}");

            Console.WriteLine();
            Console.WriteLine("Zadanie 10");
            Console.WriteLine();
            
            Console.WriteLine("Podaj pierwsza liczbe:");
            int numberFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe:");
            int secondNumber = int.Parse(Console.ReadLine());
            int NWW = numberFirst * secondNumber;

            for (int w = 1; w <= numberFirst * secondNumber; w++)
            {
                if (numberFirst % w == 0 && secondNumber % w == 0)
                    NWW = numberFirst * secondNumber / w;
            }
            Console.WriteLine(NWW);
        }   
    }    
}


