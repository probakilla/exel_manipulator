using System;
using ExelManipulator.Src.ExelParsing;

namespace ExelManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            XlsReader reader = new XlsReader("file");
            Console.Write(reader.getName());
        }
    }
}
