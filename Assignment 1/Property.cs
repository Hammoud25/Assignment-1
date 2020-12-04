namespace Assignment_1
{
    abstract class Property
    {

        public abstract int Id { get; set; }
        public abstract string Title { get; set; }
        public abstract int Price { get; set; }
        public abstract string Address { get; set; }
        public abstract PropertyTypes propertyType { get; }
    }
}
