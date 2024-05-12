using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Seminar_9
{
    public class ParseJsonToXml(string json)
    {
        public XDocument ParseJson()
        {
            JsonDocument doc = JsonDocument.Parse(json);
            XDocument xDocument = new();
            JsonElement root = doc.RootElement;
            XElement rootElement = new XElement("Root");
            parseElement(root, rootElement);
            xDocument.Add(rootElement);
            return xDocument;
        }

        private void parseElement(JsonElement element, XElement xElement = null)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Undefined:
                    break;
                case JsonValueKind.Object:
                    parseObject(element, xElement);
                    break;
                case JsonValueKind.Array:
                    parseArray(element, xElement);
                    break;
                case JsonValueKind.String:
                    parseString(element, xElement);
                    break;
                case JsonValueKind.Number:
                    parseNumber(element, xElement);
                    break;
                case JsonValueKind.True:
                case JsonValueKind.False:
                    ParseBoolean(element, xElement);
                    break;
                case JsonValueKind.Null:
                    ParseNull();
                    break;
                default:
                    throw new NotSupportedException("Unsupported JSON value kind: " + element.ValueKind);
                    break;
            }
        }

        private void parseObject(JsonElement element, XElement xElement)
        {
            foreach (var el in element.EnumerateObject())
            {
                XElement objectElement = new XElement(el.Name);
                parseElement(el.Value, objectElement);
                xElement.Add(objectElement);
            }
        }

        private void parseArray(JsonElement element, XElement xElement)
        {
            foreach (var el in element.EnumerateArray())
            {
                XElement objectElement = new XElement("Record");
                parseElement(el, objectElement);
                xElement.Add(objectElement);
            }
        }

        private void parseString(JsonElement element, XElement xElement)
        {
            xElement.Value = element.GetString();
        }

        private void parseNumber(JsonElement element, XElement xElement)
        {
            xElement.Value = element.GetRawText();
        }

        private void ParseBoolean(JsonElement element, XElement xElement)
        {
            xElement.Value = element.GetRawText();
        }

        private void ParseNull()
        {
            Console.WriteLine("Null value");
        }
    }
}