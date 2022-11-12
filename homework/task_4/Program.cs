// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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

void print_Even(int num)
{
for (int i = 1; i<=num; i++)
{
    if (i%2==0){
        Console.WriteLine(i);
    }
}
}

print_Even(AskUser());
