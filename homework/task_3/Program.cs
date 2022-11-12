// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
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
else{
    return 0;
}
}

bool isEven(int op)
{
    if (op%2 == 0){
        Console.WriteLine("True");
        return true;
    }
    else{
        Console.WriteLine("False");
        return false;
    }
}


isEven(AskUser());
