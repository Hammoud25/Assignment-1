namespace Assignment_1
{
    abstract class Property : IProperty
    {

        public Property (int id, string title, string address)
        {
            this.Id = id;
            this.Title = title;
            this.Address = address;
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public int Price { get; set; }
        public string Address { get; set; }
        public abstract PropertyTypes propertyType { get; }

        public override string ToString()
        {
            return "This is a property, Id: " + Id;
        }

        public virtual string Print()
        {
            return $"Id: { this.Id}, Title: { this.Title}";
        }
    }
}
