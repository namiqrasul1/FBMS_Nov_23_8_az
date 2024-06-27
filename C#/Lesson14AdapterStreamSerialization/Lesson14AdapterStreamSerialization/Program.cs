using Lesson14AdapterStreamSerialization.Models;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

// StreamWriter, StreamReader
// BinaryWriter, BinaryReader



//using (var fs = new FileStream("some.txt", FileMode.OpenOrCreate, FileAccess.Write))
//{
//    var data = "Hakuna Matata 42";
//    var bytes = Encoding.UTF8.GetBytes(data);
//    fs.Write(bytes, 0, bytes.Length);
//}

//var fs = new FileStream("some.txt", FileMode.OpenOrCreate, FileAccess.Write);
//using var sw = new StreamWriter(fs);

//using var sw = new StreamWriter("some.txt");

//sw.WriteLine("Matata");
//sw.WriteLine("Hakuna");
//sw.WriteLine("Hakuna");
//sw.WriteLine("Hakuna");
//sw.WriteLine("Hakuna");
//sw.WriteLine("Hakuna");
//sw.WriteLine("Hakuna");


//using var fs = new FileStream("some.txt", FileMode.Open, FileAccess.Read);
//var bytes = new byte[fs.Length];

//fs.Read(bytes, 0, bytes.Length);

//var str = Encoding.UTF8.GetString(bytes);
//Console.WriteLine(str);

//using var sr = new StreamReader("some.txt");
////var str = sr.ReadToEnd();
//var str = sr.ReadLine();
//Console.WriteLine(str);
//str = sr.ReadLine();
//Console.WriteLine(str);
//sr.Read()

// Hakuna Matata Fazil Nazim 42 



#region Serialization

void XmlSerialize(List<Car> cars)
{
    using var writer = new XmlTextWriter("cars.xml", Encoding.UTF8);
    writer.Formatting = Formatting.Indented;

    writer.WriteStartDocument();
    writer.WriteStartElement("Cars");
    foreach (Car car in cars)
    {
        writer.WriteStartElement("Car");

        writer.WriteAttributeString(nameof(car.Vendor), car.Vendor);
        writer.WriteAttributeString(nameof(car.Model), car.Model);
        writer.WriteAttributeString(nameof(car.Year), car.Year.ToString());

        //writer.WriteElementString(nameof(car.Vendor), car.Vendor);
        //writer.WriteElementString(nameof(car.Model), car.Model);
        //writer.WriteElementString(nameof(car.Year), car.Year.ToString());

        writer.WriteEndElement();
    }
    writer.WriteEndElement();
    writer.WriteEndDocument();
}

void XmlDeserialize(List<Car> cars)
{
    var xmlDocument = new XmlDocument();
    xmlDocument.Load("cars.xml");
    var root = xmlDocument.DocumentElement;

    if (root is not null)
    {
        if (root.HasChildNodes)
        {
            foreach (XmlNode node in root.ChildNodes)
            {
                Car car = new Car
                {
                    Vendor = node.Attributes![0].Value,
                    Model = node.Attributes![1].Value,
                    Year = int.Parse(node.Attributes![2].Value),
                };
                cars.Add(car);
            }
        }
    }
}


//var cars = new List<Car> { 
//    new Car{Vendor = "Ford", Model = "Mustang", Year = 1963},
//    new Car{Vendor = "Nissan", Model = "Skyline", Year = 1999},
//    new Car{Vendor = "Toyota", Model = "Supra", Year = 2000}
//};

//XmlSerialize(cars);


//var cars = new List<Car>();
//XmlDeserialize(cars);

//foreach (var car in cars)
//{
//    Console.WriteLine(car);
//    Console.WriteLine("********************");
//}



//var student = new Student
//{
//    Name = "Hakuna",
//    Surname = "Matata",
//    BirthDate = new DateOnly(1942, 12, 02).ToString(),
//    Scores = new List<int> { 5, 3, 4, 4, 5 }
//};

////Console.WriteLine(student.Average);

// Serialize
//var xml = new XmlSerializer(typeof(Student));
//using var fs = new FileStream("student.xml", FileMode.Create);
//xml.Serialize(fs, student);

// Deserialize

//Student? student = null;
//var xs = new XmlSerializer(typeof(Student));
//using var fs = new FileStream("student.xml", FileMode.Open);
//student = xs.Deserialize(fs) as Student;

//Console.WriteLine(student);




#region Json

var cars = new List<Car> {
    new Car{Vendor = "Ford", Model = "Mustang", Year = 1963, SomeProperty = "jhadh"},
    new Car{Vendor = "Nissan", Model = "Skyline", Year = 1999, SomeProperty = "jhadasdasdasdh"},
    new Car{Vendor = "Toyota", Model = "Supra", Year = 2000, SomeProperty = "jasdasdasdhadh"}
};


var json = JsonSerializer.Serialize(cars);

Console.WriteLine(json);












#endregion



#endregion