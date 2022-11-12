// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int AskUser()
{
Console.Write("Введите число: ");
string Ask = Console.ReadLine();
try
{
    int num = int.Parse(Ask);
    //num in [1,2,3,4,5,6,7];
    return num;
}
catch (Exception)
{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

string PrintWeekDays(int num)
{
    Dictionary<int, string> WeekDays = new Dictionary<int, string>()
    {
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Воскресенье"}  
};
Console.WriteLine(WeekDays[num]);
return WeekDays[num];
}

PrintWeekDays(AskUser());