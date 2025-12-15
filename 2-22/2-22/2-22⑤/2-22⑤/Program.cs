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
        Console.WriteLine(text);
    }
}

class FileOutput : IOutput
{
    public void Write( string text )
    {
        File.AppendAllText("output.txt", text + Environment.NewLine);
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