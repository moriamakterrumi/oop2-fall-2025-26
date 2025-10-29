Console.Write("Enter first number : ");
double num1 = Convert.ToDouble(Console.Readline());
Console.Write("Enter second number : ");
double num2 = Convert.ToDouble(Console.Readline());
Console.Write("Enter third number : ");
double num3 = Convert.ToDouble(Console.Readline());

double average = (num1 + num2 + num3) / 3.0;
Console.WriteLine($"Average Score: {average}");