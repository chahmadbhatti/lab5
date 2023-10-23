//213047

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] s = { "hello ", "and ", "welcome ", "to ", "this ", "demo! " };
        string mergedString = MergeStrings(s);

        Console.WriteLine(mergedString);
    }

    static string MergeStrings(string[] inputArray)
    {
        return string.Concat(inputArray);
    }
}
