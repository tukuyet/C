using System;

class Animal
{
    public string name;
    public double weight;
    public void Show()
    {
        Console.WriteLine("Name: " + name + ", Weight: " + weight);

    }
    public void SetMe(string name, double weight)
    {
        this.name = name;
        this.weight = weight;
    }
}

class Lion : Animal
{
    public Lion(string name, double weight)
    {
        SetMe(name, weight);
        Show();
    }

}

class Tiger : Animal
{
    public Tiger(string name, double weight)
    {
        SetMe(name, weight);
        Show();
    }

}
class Program
{
    public static void Main(string[] args)
    {
        Lion lion = new Lion("lion", 100);
        Tiger tiger = new Tiger("tiger", 200);
        Console.WriteLine();
    }
}