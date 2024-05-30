namespace Lesson5OOP
{
    public partial class Person : Human
    {
        public Person(int id, string name, int age, Gender gender) : base(gender)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        // private    
        // protected
        // public
        // internal
        // protected internal 
        // private protected

        public override void Run()
        {
            Console.WriteLine("Person is running");
        }

    }
}
