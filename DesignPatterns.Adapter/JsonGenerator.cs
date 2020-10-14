using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DesignPatterns.Adapter
{
    public class JsonGenerator
    {

        private IEnumerable<BankPersonel> _bankPersonels;
        public JsonGenerator(IEnumerable<BankPersonel> bankPersonels)
        {
            _bankPersonels = bankPersonels;
        }

        public string ConvertToJson() 
        {
            var generator = JsonConvert.SerializeObject(_bankPersonels);

            return generator;
        }
    }
}
