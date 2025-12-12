// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

interface IOutput
{
    void write(string text);
}
class ConsoleOutput : IOutput
{
    public void write(string text)
    {
        Console.WriteLine($"出力内容は{text}です。");
    }
}

class FileOutput : IOutput
{
    public void write( string text )
    {
        Console.WriteLine($"出力内容は{text}です。");
    }
}
class ReportPrinter
{
    private IOutput OutPut;
    public ReportPrinter( IOutput output )
    {
        OutPut = output;
    }

    public void Print( string text )
    {
        OutPut.write( text );
    }
}