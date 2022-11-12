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

int last_num(int num)
{
    int last;
    if (num<0){
        last = (-1*num)%100;
    }
    else{
        last = num%100;
    }
    last = last%10;
    Console.WriteLine(last);
    return last;
}


last_num(AskUser());