using System.Xml.Serialization;

namespace Lesson14AdapterStreamSerialization.Models
{
    [Serializable]
    public class Student
    {
        [XmlAttribute(AttributeName = "Identifier")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Surname { get; set; }
        [XmlElement]
        public string BirthDate { get; set; }
        public float Average { get => Scores.Sum() / (float)Scores.Count; }
        [XmlArray]
        public List<int> Scores { get; set; }


        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {BirthDate} {Average}";
        }
    }
}
