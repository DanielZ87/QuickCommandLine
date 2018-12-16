using System;
using QuickCommandLine.Attributes;

namespace ConsoleNetCoreSample
{
    public class SampleMethods
    {
        [Command("Hello")]
        public void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
}