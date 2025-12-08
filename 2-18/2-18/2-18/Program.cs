// See https://aka.ms/new-console-template for more information
using System;
class Employee
{
    private string EmployeeId;
    private string Name;

    public Employee(string employeeId, string name)
    {
        this.EmployeeId = employeeId;
        this.Name = name;
    }
    public string Employee_Id
    {
        get { return EmployeeId; }
        set { EmployeeId = value; }
    }
    public string _Name
    {
        get { return Name; }
        set { Name = value; }
    }
}

class Program
{
    static void Main()
    {
        Employee EInfo = new Employee("E002", "田中花子");
        Console.Write("社員ID:" + EInfo.Employee_Id + "," + "名前:" + EInfo._Name);
    }
}