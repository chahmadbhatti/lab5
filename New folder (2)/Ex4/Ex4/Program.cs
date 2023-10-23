//213047

using System;

public class Program
{
    public static void Main()
    {
        Random rand = new Random();
        int[] responses = new int[40];
        for (int i = 0; i < responses.Length; i++)
        {
            responses[i] = rand.Next(1, 6);
        }

        int[] frequency = new int[5];

        foreach (int response in responses)
        {
            frequency[response - 1]++;
        }

        for (int i = 0; i < frequency.Length; i++)
        {
            Console.WriteLine($"Response {i + 1} given by: {frequency[i]} people");
        }
    }
}
