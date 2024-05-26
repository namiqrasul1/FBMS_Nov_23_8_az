//using Student1 = AnotherLibrary.Student;
//using AnotherLibrary;
namespace Lesson4StructClass
{
    // internal, public

    class PointClass
    {
        public int x; 
        public int y;

        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public void Print()
        {
            Console.WriteLine($"{x} {y}");
        }
    }
}
