using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using TicketsLib;
using System.Windows.Forms;

namespace UtilsLib
{
    public class TicketJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(Ticket).IsAssignableFrom(objectType); ;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            JToken typeToken = jsonObject["Type"];

            if (typeToken == null)
            {
                throw new JsonSerializationException("The 'Type' property is missing");
            }

            string typeName = typeToken.Value<string>();
            Ticket ticket;

            switch (typeName)
            {
                case "StandartTicket":
                    ticket = new StandartTicket();
                    break;
                case "DiscountTicket":
                    ticket = new DiscountTicket();
                    break;
                default:
                    throw new Exception($"Unknown ticket type: {typeName}");
            }

            serializer.Populate(jsonObject.CreateReader(), ticket);
            return ticket;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.FromObject(value);
            jsonObject.AddFirst(new JProperty("Type", value.GetType().Name));
            jsonObject.WriteTo(writer);
        }
    }
}
