﻿uint n;
try
{
    n = GetNumber("Enter your number: ");
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

Recursion(n);



void Recursion(uint n)
{
    if (n > 1)
    {
        Console.Write($"{n}, ");
        n = n - 1;
        Recursion(n);
    }
    else
    {
        Console.Write(n);
    }
}



uint GetNumber(string message)
{
    Console.Write(message);
    bool isParsed = uint.TryParse(Console.ReadLine(), out uint number);
    if (isParsed)
    {
        return number;
    }
    else
    {
        throw new FormatException("Invalid value entered!");
    }
}