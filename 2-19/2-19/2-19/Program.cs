// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        TestInfo name = new TestInfo("山田", 20, 170, 60);

    }
}

class TestPerson
{
    public string name;
    public int age;

    public TestPerson(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine("基底クラス");
        Console.WriteLine($"名前：{name},年齢：{age}");

    }
}
class TestInfo : TestPerson
{
    public int height;
    public int weight;
    public TestInfo(string name,int age,int height, int weight) : base(name,age)
    {
        this.height = height;
        this.weight = weight;
        Console.WriteLine("派生クラス");
        Console.WriteLine($"身長：{height},体重：{weight}");
    }
}