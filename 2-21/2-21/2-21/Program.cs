// See https://aka.ms/new-console-template for more information
using System;

interface IBillable
{
    int CostForDay(int hoursWorked);
}

abstract class Employee:IBillable
{
    public string Id { get; set; }
    public string Name { get; set; }
    public Employee(string id, string name)
    {
        Id = id;
        Name = name;
    }
    public abstract int CostForDay(int hoursWorked);
}

class FullTimeEmployee: Employee
{
    public FullTimeEmployee(string id, string name) : base(id, name)
    {
    }

    public override int CostForDay(int hoursWorked)
    {
        int wage = 1250 * hoursWorked;
        if (hoursWorked > 8)
        {
            wage += (int)(1250 * 1.25 * (hoursWorked - 8));
        }
        return wage;
    }
}

class ContractEmployee:Employee
{
    public ContractEmployee(string id, string name) : base(id, name)
    {
    }
    public override int CostForDay(int hoursWorked)
    {
        int wage = 1000 * hoursWorked;
        return wage;
    }
}
class Program
{
    static void Main()
    {
        List<Employee> list = new List<Employee>();
        list.Add(new FullTimeEmployee("E002", "山田太郎"));
        list.Add(new ContractEmployee("C001", "田中花子"));
        list.Add(new FullTimeEmployee("E003", "鈴木一郎"));
        foreach (var emp in list)
        {
            int wage = emp.CostForDay(9);
            Console.WriteLine($"日給：{wage}円");
        }
    }
}