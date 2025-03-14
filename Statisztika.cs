namespace motors;

internal class Statisztika
{
    private List<Motor> motors = new List<Motor>();


    public void ReadFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            string brand = parts[0];
            string name = parts[1];
            int releaseYear = int.Parse(parts[2]);
            double performance = double.Parse(parts[3]);
            double priceInEur = double.Parse(parts[4]);
            Motor motor = new Motor(brand, name, releaseYear, performance, priceInEur);
            motors.Add(motor);
        }
    }

   


}
