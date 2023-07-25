using AutoBogus;
using Bogus;

internal class Program
{
    private static void Main(string[] args)
    {
        var list = new List<long>() { 1, 20, 38, 44, 50, 68, 71, 80, 93, 105 };
        var number = 20;
        Console.WriteLine("Final guess: " + Algo.BynarySearch(number, list));
    }
}

public class Algo
{
    public static long? BynarySearch(long number, List<long> list)
    {
        Console.WriteLine("Array: " + string.Join(", ", list));
        Console.WriteLine("Correct number: " + number);

        int index = (list.Count - 1) / 2;
        var guess = list[index];

        while (guess != number)
        {
            if (guess > number) index /= 2;
            else index += index / 2;

            Console.WriteLine("Guess: " + guess);

            if (index <= 0 || index >= list.Count) return null;

            guess = list[index];
        }

        return guess;
    }
}