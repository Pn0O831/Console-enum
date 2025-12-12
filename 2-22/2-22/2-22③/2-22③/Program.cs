// See https://aka.ms/new-console-template for more information

abstract class Employee
{
    public void Work(int hours)
    {
    }
}

class FullTimeEmployee
{
    public void Work(int hours)
    {
        Console.WriteLine($"{hours}時間働きました。");
    }
}
class InternEmployee
{
    public void Work(int hours)
    {
        if (hours > 4)
            Console.WriteLine("最大４時間までしか働けません");
        else Console.WriteLine($"{hours}時間働きました");
    }
}