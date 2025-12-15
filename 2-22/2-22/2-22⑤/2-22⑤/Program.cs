// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Runtime.CompilerServices;

interface IOutput
{
    void Write(string text);
}
class ConsoleOutput : IOutput
{
    public void Write(string text)
    {
        Console.WriteLine($"出力内容は{text}です。");
    }
}

class FileOutput : IOutput
{
    public void Write( string text )
    {
        File.AppendAllText("output.txt", "2-22⑤のテスト");
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
        OutPut.Write( text );
    }
}