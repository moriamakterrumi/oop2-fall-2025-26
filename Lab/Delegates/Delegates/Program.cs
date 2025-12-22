using Delegate;

namespace Delegate
{
    public delegate int Operation(int a, int b);
}

class Program
{
    static int add(int a, int b)
    {
        return a + b;
    }
    static int sub(int a, int b)
    {
        return a - b;
    }
    static int mul(int a, int b)
    {
        return a * b;
    }
    static int div(int a, int b)
    {
        return a / b;
    }

    static void Calculate(int a, int b, Operation op)
    {
        int result = op(a, b);
        Console.WriteLine("Result is: " + result);
    }

    static void Main(string[] args)
    {
        Calculate(5,10, add);
        Calculate(20, 2, sub);
        Calculate(2, 4, mul);
        Calculate(25, 5, div);
    }

}