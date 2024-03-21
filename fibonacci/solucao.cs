using System;

class Program
{
    static void Main(string[] args)
    {
        foreach (int num in Fibonacci(10))
        {
            Console.Write(num + " ");
        }
    }

    static int[] Fibonacci(int number)
    {
        int[] sequence = new int[number];
        sequence[0] = 0;
        sequence[1] = 1;

        for (int i = 2; i < number; i++)
        {
            sequence[i] = sequence[i - 1] + sequence[i - 2];
        }

        return sequence;
    }
}
