using System.Text.Json.Serialization;

namespace Lesson14AdapterStreamSerialization.Models
{
    internal class Car
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public string Vendor { get; set; }
        [JsonIgnore]
        public string SomeProperty { get; set; }

        public override string ToString()
        {
            return $"Vendor: {Vendor}\nModel: {Model}\nYear: {Year}";
        }
    }
}
