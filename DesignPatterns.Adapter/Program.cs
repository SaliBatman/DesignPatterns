using System;

namespace DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlGenerator = new XmlGenerator();
            var xPersonels = xmlGenerator.GetXml();

            Console.WriteLine(xPersonels);
            var adapter = new XmlToJsonWrapper(xmlGenerator);
            adapter.ConvertToJson();
            Console.ReadLine();
        }
    }
}
