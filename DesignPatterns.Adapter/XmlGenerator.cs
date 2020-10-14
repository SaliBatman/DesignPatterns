using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DesignPatterns.Adapter
{
    public class XmlGenerator
    {
        public XDocument GetXml() 
        {

            var xDocument = new XDocument();
            var xElement = new XElement("BankPersonels");
            var xAttr = DataWrapper.GetData().Select(s => new XElement("Personels",
                new XAttribute("Name", s.Name),
                new XAttribute("City", s.City),
                new XAttribute("Age", s.Age)


                ));


            xElement.Add(xAttr);
            xDocument.Add(xElement);

            return xDocument;
        
        }

    }
}
