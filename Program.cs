namespace motors;
internal class Program
{
    private static void Main(string[] args)
    {
        Statisztika statisztika = new Statisztika();
        statisztika.ReadFromFile("/home/mikes/Documents/c#/motors/data.txt");
        Console.WriteLine($"Oldest motor: {statisztika.Oldest()}");
        Console.WriteLine($"Total price of all motors: {statisztika.SumPrices()}");
        Console.WriteLine($"Contains Yamaha: {statisztika.Contains("Yamaha")}");
        Console.WriteLine($"Sum of prices for Yamaha motors: {statisztika.SumBasedOnBrand("Yamaha")}");


    }
}