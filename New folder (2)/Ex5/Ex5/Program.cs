﻿//213047

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Decimal to Binary Conversion");
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binaryResult = ConvertDecimalToBinary(decimalNumber);
        Console.WriteLine($"Binary representation: {binaryResult}");

        Console.WriteLine("\nBinary to Decimal Conversion");
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        int decimalResult = ConvertBinaryToDecimal(binaryNumber);
        Console.WriteLine($"Decimal representation: {decimalResult}");
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 2);
    }

    static int ConvertBinaryToDecimal(string binaryNumber)
    {
        return Convert.ToInt32(binaryNumber, 2);
    }
}
