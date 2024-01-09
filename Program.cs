using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program do znajdowania liczb pierwszych w ciągu liczb całkowitych.");

        Console.Write("Podaj ciąg liczb całkowitych oddzielonych separatorem (np. 1,5,24,8,150,2): ");
        string input = Console.ReadLine();

        List<int> numbers = input.Split(',').Select(int.Parse).ToList();

        List<int> primeNumbers = FindPrimeNumbers(numbers);

        Console.WriteLine("Liczby pierwsze w podanym ciągu:");
        foreach (var prime in primeNumbers)
        {
            Console.Write(prime + " ");
        }

        Console.WriteLine("\nKoniec programu.");
    }

    static List<int> FindPrimeNumbers(List<int> numbers)
    {
        List<int> primeNumbers = new List<int>();

        foreach (var number in numbers)
        {
            if (IsPrime(number))
            {
                primeNumbers.Add(number);
            }
        }

        return primeNumbers;
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
