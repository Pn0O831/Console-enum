// See https://aka.ms/new-console-template for more information

interface IWorkable
{
    void Work();
}
interface IEatable
{
    void Eat();
}
class Robot : IWorkable
{
    public void Work()
    {
        Console.WriteLine("ロボットが働きます。");
    }
}
class Engineer : IWorkable,IEatable
{
    public void Work()
    {
        Console.WriteLine("エンジニアが働きます。");
    }
    public void Eat()
    {
        Console.WriteLine("エンジニアが食事をします。");
    }
}