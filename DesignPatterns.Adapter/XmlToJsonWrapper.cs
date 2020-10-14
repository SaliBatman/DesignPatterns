using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class XmlToJsonWrapper : IXmlToJson
    {

        private XmlGenerator _xmLGenerator;
        public XmlToJsonWrapper(XmlGenerator xmlGenerator)
        {
            _xmLGenerator = xmlGenerator;
        }
        public void ConvertToJson()
        {
            var getXml = _xmLGenerator.GetXml().Element("BankPersonels").Elements("Personels").Select(s=> new BankPersonel 
            {
                Name = s.Attribute("Name").Value,
                Age = Convert.ToInt32(s.Attribute("Age").Value),
                City = s.Attribute("City").Value
            });
            Console.WriteLine(new JsonGenerator(getXml).ConvertToJson());
        }
    }
}
