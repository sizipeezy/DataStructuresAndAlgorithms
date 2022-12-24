using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        ProcessSettings();
    }

    static void ProcessSettings()
    {
        XDocument xml = XDocument.Load("settings.xml");

        var appSettings = xml.Descendants("appSettings")
            .Descendants("add")
            .Select(node => new
            {
                Key = node.Attribute("key")?.Value,
                Value = node.Attribute("value")?.Value
            })
            .ToArray();

        foreach (var item in appSettings)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}