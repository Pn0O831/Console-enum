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
        Console.WriteLine("社員ID:" + EInfo.Employee_Id + "," + "名前:" + EInfo._Name);

        //Copilot練習問題１
        Student a = new Student("山田太郎", 101);
        Console.WriteLine($"{a.Name}のスコア{a.Score}");

        //Copilot練習問題2
        Worker s = new Worker("")
    }
    static void Next()
    {
    }
}

class Student
{
    private string name;
    private int score;

    public Student(string name, int score)
    {
        this.Name = name;
        this.Score = score;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Score
    {
        get { return score; }
        set
        {
            if (0 <= value && value <= 100)
            {
                Score = value;
            }
            else
            {
                Console.WriteLine("数値は0～100の範囲で入力してください");
            }
        }
    }
}

class Worker
{
    private string id;
    private string name;
    private int salary;

    public Worker(string id, string name, int salary)
    {
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
    }

    public string Id
    {
        get { return id; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Salary
    {
        get { return salary; }
        set
        {
            if (value >= 0)
            {
                salary = value;
            }
            else
            {
                Console.WriteLine("エラー:給与は0以上の数字で入力してください");
            }
        }
    }
}