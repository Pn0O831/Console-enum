// See https://aka.ms/new-console-template for more information

abstract class Employee
{
    public abstract void Work(int hours);
}

class FullTimeEmployee : Employee
{
    public override void Work(int hours)
    {
        Console.WriteLine($"{hours}時間働きました。");
    }
}
abstract class LimitedHourEmployee : Employee
{
    private readonly int MaxHours;

    protected LimitedHourEmployee(int maxHours)
    {
        MaxHours = maxHours;
    }
    public override void Work(int hours)
    {
        if (hours > MaxHours)
        {
            Console.WriteLine($"{MaxHours}時間しか働けません");
        }
        else
        {
            Console.WriteLine($"{hours}時間働きました");
        }
    }
}
class InternEmployee : LimitedHourEmployee
{
    public InternEmployee() : base(4)
    {

    }
}