class AnonTypes
{
    static void Main(string[] args)
    {
        var p1 = new { Name ="A", Price =3};
        Console.WriteLine("Name = {0}\nPrice = {1}",
                          p1.Name.ToLoWer(),p1.Price);
        Console.ReadLine();
    }
}