// See https://aka.ms/new-console-template for more information
using System;
class Employee
{
    public string EmployeeId { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Employee No1 = new Employee();
        No1.EmployeeId = "E002";
        No1.Name = "田中花子";
        Console.WriteLine("社員ID:" + No1.EmployeeId + "," + "名前:" + No1.Name);
    }
}