namespace PrototypePattern
{
    internal class Product : ICloneable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public object Clone()
        {
            return new Product { Name = Name, Price = Price };
        }
    }
}
