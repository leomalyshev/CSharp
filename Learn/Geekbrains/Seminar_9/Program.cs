using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

namespace Seminar_9
{
    internal class Program
    {
        public static string json = """
                                    {"Current":{"Time":"2023-06-18T20:35:06.722127+04:00","Temperature":29,"Weathercode":1,"Windspeed":2.1,"Winddirection":1},
                                    "History":[{"Time":"2023-06-17T20:35:06.77707+04:00","Temperature":29,"Weathercode":2,"Windspeed":2.4,"Winddirection":1},
                                    {"Time":"2023-06-16T20:35:06.777081+04:00","Temperature":22,"Weathercode":2,"Windspeed":2.4,"Winddirection":1},
                                    {"Time":"2023-06-15T20:35:06.777082+04:00","Temperature":21,"Weathercode":4,"Windspeed":2.2,"Winddirection":1}]}
                                    """;

        static void Main(string[] args)
        {
            /*
            string s = "<?xml version=\"1.0\" encoding=\"utf-8\"?> " +
                       "<Data.Root xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  " +
                       "<Data.Root.Names>    " +
                       "<Name>Name1</Name>   " +
                       " <Name>Name2</Name>    " +
                       "<Name>Name3</Name>  " +
                       "</Data.Root.Names>  " +
                       "<Data.Entry LinkedEntry=\"Name1\">    " +
                       "<Data.Name>Name2</Data.Name> " +
                       " </Data.Entry>  " +
                       "<Data_x0023_ExtendedEntry LinkedEntry=\"Name2\">   " +
                       " <Data.Name>Name1</Data.Name>   " +
                       " <Data_x0023_Extended>NameOne</Data_x0023_Extended>  " +
                       "</Data_x0023_ExtendedEntry> </Data.Root>";


            var dl = new DataRoot
            {
                Names = new List<string> { "Name1", "Name2", "Name3" },
                Entries = new List<DataEntry>
                {
                    new DataEntry { LinkedEntry = "Name1", Name = "Name2" },
                    new DataEntryExtended { LinkedEntry = "Name2", Name = "Name1", ExtendedEntry = "NameOne" }
                }
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataRoot));

            xmlSerializer.Serialize(Console.Out, dl);

            using (StringReader streamReader = new StringReader(s))
            {
                DataRoot v = xmlSerializer.Deserialize(streamReader) as DataRoot;
            }
            */
            //var res = (new JsonParser()).ParseJson(json, "Temperature");
            //foreach (var r in res)
            //{
            //    Console.WriteLine(r);
            //}


            ParseJsonToXml parseJsonToXml = new ParseJsonToXml(json);
            XDocument xDocument = parseJsonToXml.ParseJson();
            Console.WriteLine(xDocument);
        }
    }
}

public class JsonParser
{
    private string _value;

    private List<string> _results = new List<string>();

    public List<string> ParseJson(string json, string value)
    {
        _value = value;

        JsonDocument doc = JsonDocument.Parse(json);

        JsonElement root = doc.RootElement;
        parseElement(root);
        return _results;
    }

    private void parseElement(JsonElement root, bool save = false)
    {
        switch (root.ValueKind)
        {
            case JsonValueKind.Undefined:
                break;
            case JsonValueKind.Object:
                parseObject(root);
                break;
            case JsonValueKind.Array:
                parseArray(root);
                break;
            case JsonValueKind.String:
                parseString(root, save);
                break;
            case JsonValueKind.Number:
                parseNumber(root, save);
                break;
            case JsonValueKind.True:
            case JsonValueKind.False:
                ParseBoolean(root);
                break;
            case JsonValueKind.Null:
                ParseNull();
                break;
            default:
                throw new NotSupportedException("Unsupported JSON value kind: " + root.ValueKind);
                break;
        }
    }

    private void parseObject(JsonElement element)
    {
        foreach (var el in element.EnumerateObject())
        {
            Console.WriteLine($"Property = {el.Name}");
            bool save = el.Name == _value;
            parseElement(el.Value, save);
        }
    }

    private void parseArray(JsonElement element)
    {
        foreach (var el in element.EnumerateArray())
        {
            parseElement(el);
        }
    }

    private void parseString(JsonElement element, bool save = false)
    {
        if (save)
        {
            _results.Add(element.GetString());
        }

        Console.WriteLine($"String = {element.GetString()}");
    }

    private void parseNumber(JsonElement element, bool save = false)
    {
        if (save)
        {
            _results.Add(element.GetRawText());
        }

        Console.WriteLine($"Number = {element.GetRawText()}");
    }

    private void ParseBoolean(JsonElement element)
    {
        Console.WriteLine("Boolean value: " + element.GetRawText());
    }

    private void ParseNull()
    {
        Console.WriteLine("Null value");
    }
}


public class WeatherInfo
{
    public DateTime Time { get; set; }
    public double Temperature { get; set; }
    public int Weathercode { get; set; }
    public double Windspeed { get; set; }
    public int Winddirection { get; set; }
}

public class WeatherData
{
    public object name;
    public WeatherInfo Current { get; set; }
    public List<WeatherInfo> History { get; set; }
}


[XmlRoot("Data.Root")]
public class DataRoot
{
    [XmlArray("Data.Root.Names")] [XmlArrayItem("Name")]
    public List<string> Names = new List<string>();

    [XmlElement(typeof(DataEntry))] [XmlElement(typeof(DataEntryExtended))]
    public List<DataEntry> Entries = new List<DataEntry>();
}

[XmlType("Data.Entry")]
public class DataEntry
{
    [XmlAttribute] public string LinkedEntry;

    [XmlElement("Data.Name")] public string Name;
}

[XmlType("Data#ExtendedEntry")]
public class DataEntryExtended : DataEntry
{
    [XmlElement("Data_x0023_Extended")] public string ExtendedEntry;
}

