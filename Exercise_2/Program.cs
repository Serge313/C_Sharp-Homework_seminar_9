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

uint sum = Recursion(m, n);
Console.Write($"m = {m}, n = {n} -> {sum}");



uint Recursion(uint m, uint n)
{
    if (m == n)
    {
        return m;
    }
    return n + Recursion(m, n - 1);
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