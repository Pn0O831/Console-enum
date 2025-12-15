// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
//①
class Report
{
    private string EmployeeName;
    private int HoursWorked;
}

class ReportCalculator
{
    int CalculateWage(Report report)
    {
        int wage = 1250 * report.HoursWorked;
        return wage;
    }
}
class ReportSaver
{
    void Save(Report report,string filePath)
    {
        File.WriteAllText(filePath,$"{report.EmployeeName},");
        Console.WriteLine($"{report.EmployeeName}を、保存しました。");
    }
}