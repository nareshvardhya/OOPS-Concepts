using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    static void Main()
    {
        Calculator obj = new Calculator();
        Console.WriteLine(obj.Add(5, 10));       
        Console.WriteLine(obj.Add(5, 10, 15));   
    }
}
