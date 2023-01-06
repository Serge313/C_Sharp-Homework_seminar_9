uint m;
try
{
    m = GetNumber("Enter your number \"m\": ");
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

uint n;
try
{
    n = GetNumber("Enter your number \"n\": ");
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    return;
}

uint result = Recursion(m, n);
Console.Write($"A(m, n) = {result}");



uint Recursion(uint m, uint n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Recursion(m - 1, 1);
    }
    else
    {
        return Recursion(m - 1, Recursion(m, n -1));
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