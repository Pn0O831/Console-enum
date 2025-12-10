// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;

abstract class Employee
{
    public string Id;
    public string Name;

    public Employee(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract int CalculateDailyWage(int hoursWorked);
}

class FullTimeEmployee:Employee
{
    public FullTimeEmployee(string id, string name):base(id, name)
    {
    }
    public override int CalculateDailyWage(int hoursWorked)
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
    public ContractEmployee(string id,string name):base(id, name)
    {
    }
    public override int CalculateDailyWage(int hoursWorked)
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
        list.Add(new ContractEmployee("C002", "佐藤花子"));
        list.Add(new FullTimeEmployee("E003", "鈴木一郎"));
        foreach (var item in list)
        {
            double wage = item.CalculateDailyWage(8);
            Console.WriteLine($"社員ID：{item.Id} 名前：{item.Name} 給料：{wage}");
        }
    }
}