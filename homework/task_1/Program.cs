// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string Ask = Console.ReadLine();
try
{
    int op = int.Parse(Ask);
    return op;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

void MaxMin(int op1, int op2)
{
    int max, min;
    if (op1>op2){
        max = op1;
        min = op2;
    }
    else {
        max = op2;
        min = op1;
    }
    Console.WriteLine($"Max number: {max}");
    Console.WriteLine($"Min number: {min}");
}

MaxMin(AskUser(), AskUser());
