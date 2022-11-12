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

int Max(int op1, int op2, int op3)
{
    int max;
    if (op1>op2){
        max = op1;
    }
    else {
        max = op2;
    }
    if (op3>max){
        max = op3;
    }
    Console.WriteLine($"Max number: {max}");
    return max;
}

Max(AskUser(), AskUser(), AskUser());