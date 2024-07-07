namespace PrototypePattern
{
    internal class Country : IPrototype
    {
        public string Name { get; set; }
        public decimal Population { get; set; }

        public IPrototype Clone()
        {
            return new Country() { Name = this.Name, Population = this.Population };
        }
    }
}
