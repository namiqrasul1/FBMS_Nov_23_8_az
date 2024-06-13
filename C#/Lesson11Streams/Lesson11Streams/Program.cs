using Lesson11Streams.Models;
using System.Text;
using System.Text.Json;


// stream

// MemoryStream (c++ => stringstream)
// FileStream
// NetworkStream

// AdapterStream
// StreamWriter, StreamReader
// BinaryWriter, BinaryReader

// File, FileInfo
// Directory, DirectoryInfo
// Path // @"C:\Users\namiqrasullu\Desktop\Инструкция_Microsoft_365.pdf"

//Console.WriteLine(Directory.GetCurrentDirectory());


//var data = "Hakuna Matata 42";

//FileStream fs = new FileStream(@"C:\Users\namiqrasullu\Desktop\text.txt", FileMode.OpenOrCreate, FileAccess.Write);

//try
//{
//    byte[] bytes = Encoding.UTF8.GetBytes(data);
//    fs.Write(bytes);
//    //fs.Flush();
//    fs.Write(bytes);
//}
//finally
//{
//    fs.Close();
//    fs.Dispose();
//}

//using (FileStream fs = new FileStream(@"C:\Users\namiqrasullu\Desktop\text.txt", FileMode.OpenOrCreate, FileAccess.Write))
//{
//    data = "john doe";
//    byte[] bytes = Encoding.UTF8.GetBytes(data);
//    fs.Write(bytes);
//    fs.Flush();
//    fs.Write(bytes);
//}


//using FileStream fs = new FileStream(@"C:\Users\namiqrasullu\Desktop\text.txt", FileMode.OpenOrCreate, FileAccess.Write);

//data = "john doe";
//byte[] bytes = Encoding.UTF8.GetBytes(data);
//fs.Write(bytes);
//fs.Flush();
//fs.Write(bytes);



//using var fs = new FileStream(@"C:\Users\namiqrasullu\Desktop\text.txt", FileMode.Open);

//byte[] bytes = new byte[fs.Length];
//fs.Read(bytes, 0, bytes.Length);
//var data = Encoding.UTF8.GetString(bytes);

//Console.WriteLine(data);


//List<Book> books = new()
//{
//    new Book { Id= 1, Name = "Sefiller", Author = "Victor Hugo", Jenre = "Drama" },
//    new Book { Id= 2, Name = "Angels and Demons", Author = "Dan Brown", Jenre = "Dedective" },
//    new Book { Id= 3, Name = "Anna Karenina", Author = "Lev Tolstoy", Jenre = "Dedective" }
//};


//try
//{
//    using var fs = new FileStream("books.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
//    foreach (var book in books)
//    {
//        var bytes = Encoding.UTF8.GetBytes(book.ToString() + "\n");
//        fs.Write(bytes);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



#region Copy File

//var sourcePath = @"C:\Users\namiqrasullu\Downloads\Collections.jpg";
//var destPath = @"C:\Users\namiqrasullu\Desktop\New folder\image1.jpg";

//using (var source = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
//{
//    using (var dest = new FileStream(path: destPath,
//                                    mode: FileMode.Create, 
//                                    access: FileAccess.Write))
//    {
//        //source.CopyTo(dest);

//        var fileSize = source.Length;
//        var len = 15;
//        var buffer = new byte[len];
//        do
//        {
//            len = source.Read(buffer, 0, len);
//            dest.Write(buffer, 0, len);
//            Console.WriteLine(fileSize);
//            fileSize -= len;

//        } while (len != 0);

//    }
//}

#endregion


#region Json Serialization (JavaScript Object Notation)

//var book = new Book { Id = 1, Name = "Sefiller", Author = "Victor Hugo", Jenre = "Drama" };
//var json = JsonSerializer.Serialize(book);
//Console.WriteLine(json);

//File.WriteAllText(path: "book.json", json);

//var json = File.ReadAllText("book.json");
//Book? book = JsonSerializer.Deserialize<Book>(json);

//Console.WriteLine(book?.Name);
//Console.WriteLine(book?.Author);
//Console.WriteLine(book?.Jenre);
//Console.WriteLine(book?.Id);

//List<Book> books = new()
//{
//    new Book { Id= 1, Name = "Sefiller", Author = "Victor Hugo", Jenre = "Drama" },
//    new Book { Id= 2, Name = "Angels and Demons", Author = "Dan Brown", Jenre = "Dedective" },
//    new Book { Id= 3, Name = "Anna Karenina", Author = "Lev Tolstoy", Jenre = "Dedective" }
//};

//var json = JsonSerializer.Serialize(books);
//File.WriteAllText(path: "books.json", contents: json);



var booksJson = File.ReadAllText("books.json");

var bookList = JsonSerializer.Deserialize<List<Book>>(booksJson);



using Book b = new Book();



#endregion