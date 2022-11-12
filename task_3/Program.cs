// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string Ask = Console.ReadLine();
try
{
    int num = int.Parse(Ask);
    return num;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

int print_all(int num)
{
for (int i = -1*num; i<=num; i++)
{
    Console.WriteLine(i);
}
return num;
}

print_all(AskUser());

