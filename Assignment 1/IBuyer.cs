namespace Assignment_1
{
    interface IBuyer
    {
        string FullName { get; set; }
        int Credit { get; set; }
        int Id { get; set; }
        Blist blist { get; set; }
    }
}
