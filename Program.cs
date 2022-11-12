// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

double AskUser()
{
Console.Write("Введите число: ");
string Ask = Console.ReadLine();
try
{
    double op = double.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

double Square(double op)
{
    double result;
    result = Math.Pow(op, 2);
    Console.WriteLine(result);
    return result;
}


Square(AskUser());