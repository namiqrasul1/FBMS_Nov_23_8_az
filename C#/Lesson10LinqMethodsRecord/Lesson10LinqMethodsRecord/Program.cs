using Lesson10LinqMethodsRecord.Extensions;
using Lesson10LinqMethodsRecord.Students;



var students = new List<Student>()
{
    new Student { Name = "Ali", Surname = "Mustafayev", DateOfBirth = new DateOnly(2009, 06, 20) },
    new Student { Name = "Tahir", Surname = "Aliyev", DateOfBirth = new DateOnly(2001, 08, 01) },
    new Student { Name = "Seltenet", Surname = "Suleymanli", DateOfBirth = new DateOnly(2004, 01, 31) },
    new Student { Name = "Abdulla", Surname = "Babayev", DateOfBirth = new DateOnly(2005, 02, 07) },
    new Student { Name = "Arzum", Surname = "Hasanzade", DateOfBirth = new DateOnly(2009, 10, 01) },
    new Student { Name = "Asgar", Surname = "Abbasli", DateOfBirth = new DateOnly(2008, 06, 22) },
    new Student { Name = "Ismayil", Surname = "Bagirov", DateOfBirth = new DateOnly(2008, 03, 15) },
};

// 18 yashdan yuxari telebelerin butun adini siralanmish shekilde goturmeliyik
var result = students.Where(st => DateTime.Now.Year - st.DateOfBirth.Year > 17)
                    .Select(st => $"{st.Name} {st.Surname}")
                    .Order()
                    .ToList();






//var r = students.GetOlderStudent();
//Console.WriteLine(r);

// IEnumerable

//var st = students.First();
//st = students.FirstOrDefault(s => s.DateOfBirth.Year < 2004);
//if(st is not null)
//{
//    st.Name = "Hakuna";
//    //Console.WriteLine(st);
//}


//foreach (var stud in students)
//{
//    Console.WriteLine(stud);
//}


//var avg = students.Average(s => s.DateOfBirth.Year);
//Console.WriteLine(avg);


//var orderedList = students.OrderBy(s => s.DateOfBirth).ToList();

//foreach (var item in orderedList)
//{
//    Console.WriteLine(item);
//}

//var orderedList1 = students.OrderBy(s => s.Name).ToList();
//Console.WriteLine("************************************");
//foreach (var item in orderedList1)
//{
//    Console.WriteLine(item);
//}

//var names = students.Select(s => s.Name).ToList();

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

//var fullNames = students.Select(s => $"{s.Name} {s.Surname}").ToList();

//foreach (var fn in fullNames)
//{
//    Console.WriteLine(fn);
//}

//var dtos = students.Select(s => new { Name = s.Name, Surname = s.Surname }).ToList();
//foreach (var dto in dtos)
//{
//    Console.WriteLine(dto);
//}

//var studentDtos = students.Select(s => new StudentDto(Name: s.Name, Surname: s.Surname ));

//foreach (var student in studentDtos)
//{
//    Console.WriteLine(student);
//}

//var s = students.Single(s => s.Name.Contains('Q')); // sherte uygun tek element varsa hemin elemente reference qaytarir, choxdursa ve yoxdusa exception atir
//var s = students.SingleOrDefault(s => s.Name.Contains('a')); // sherte uygun tek element varsa hemin elemente reference qaytarir, yoxdursa default deyer qaytarir, choxdursa exception atir

//Console.WriteLine(s);

//var studs = students.Skip(3).ToList();
//var studs = students.SkipLast(3).ToList();
//var studs = students.SkipWhile(st => st.Name.ToLower().Contains('a'));

//foreach (var st in studs)
//{
//    Console.WriteLine(st);
//}


//var adults = students.Where(st => st.DateOfBirth.Year <= 2006).ToList();

//foreach (var item in adults)
//{
//    Console.WriteLine(item);
//}

//var studs = students.Where(st => !(st.DateOfBirth.Year <= 2006)).ToList();

//foreach (var item in studs)
//{
//    Console.WriteLine(item);
//}





















#region Anonymous Type      

//object getS(Student student) => new { Name = student.Name, Surname = student.Surname };


//var student = new Student
//{
//    Name = "Hakuna",
//    Surname = "Matata",
//    DateOfBirth = new(2042, 12, 12)
//};

//var anonym = new { Name = "Kamil", Surname = "Kamilli", Mothertown = "Shrilanka" };
//Console.WriteLine(anonym.Name);

#endregion