namespace Lesson5OOP
{
    public class Human(Gender gender)
    {
        //private protected Gender Gender1 { get; set; }
        public Gender Gender { get; set; } = gender;

        public virtual void Run()
        {
            Console.WriteLine("Human is running");
            
        }
    }
}
