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
            ////Zadanie 1
            bool isPrime = true;
            int i;
            int j;
            int primeCounter = 0;
            for (i = 2; i <= 100; i++)
            {
                isPrime = true;
                for (j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
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

            ////Zadanie 2 
            int k = 0;
            do
            {
                k++;
                if (k % 2 == 0)
                {
                    Console.WriteLine("Liczba to: {0}", k);
                }
            }
            while (k <= 1000);

            ////Zadanie 3
            int firstNumber = 0, SecondNumber = 1, nextNumber;
            Console.Write(firstNumber + " " + SecondNumber + " ");
            nextNumber = firstNumber + SecondNumber;

            for (int l = 2; nextNumber < 100; l++)
            {
                Console.Write(nextNumber + " ");
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
                nextNumber = firstNumber + SecondNumber;
            }

            ////Zadanie 4
            int counter = 1;
            for (int m = 1; m <= 4; m++)
            {
                for (int n = 1; n <= m; n++)
                {
                    Console.Write($"{counter++} ");
                }
                Console.Write("\n");
            }
            ////Zadanie 5 
            for (int o = 1; o <= 20; o++)
            {
                Console.WriteLine(o * o * o);
            }

            ////Zadanie 6
            for (decimal p = 1; p <= 20; p++)
            {
                Console.WriteLine(p + 1 / p);
            }

            //Zadanie 7
            int numberRow = 4;
            int space;
            int row;
            int star;
            for (row = 1; row <= numberRow; row++)
            {
                for (space = 1; space <= numberRow - row; space++)
                {
                    Console.Write(" ");
                }
                for (star = 1; star <= 2 * row - 1; star++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (row = numberRow - 1; row >= 1; row--)
            {
                for (space = 1; space <= numberRow - row; space++)
                {
                    Console.Write(" ");
                }
                for (star = 1; star <= 2 * row - 1; star++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
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

            // Zadanie 8 
            string normalWritten = "Abcdefg";
            string reverse = "";
            for (int z = normalWritten.Length-1; z >= 0; z--)
            {
                reverse += normalWritten[z];
            }
            Console.WriteLine(reverse);

            //Zadanie 9 - decimal -> binary
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
            Console.WriteLine("Liczba binarna to: {0}", result);

            //Zadanie 10 
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


