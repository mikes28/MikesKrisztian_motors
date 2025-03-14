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
            int releaseYear = Convert.ToInt32(parts[2]);
            double performance = double.Parse(parts[3]);
            double priceInEur = double.Parse(parts[4]);
            Motor motor = new Motor(brand, name, releaseYear, performance, priceInEur);
            motors.Add(motor);
        }
    }

    public int SumPrices()
    {
        double sum = 0;
        foreach (Motor motor in motors)
        {
            sum += motor.PriceInEur;
        }
        return Convert.ToInt32(sum);
    }

    public bool Contains(string motorName)
    {
        foreach (Motor motor in motors)
        {
            if (motor.Name == motorName)
            {
                return true;
            }
        }
        return false;
    }

    public Motor Oldest()
    {
        Motor oldest = motors[0];
        foreach (Motor motor in motors)
        {
            if (motor.ReleaseYear < oldest.ReleaseYear)
            {
                oldest = motor;
            }
        }
        return oldest;
    }


    public int SumBasedOnBrand(string brandName)
    {
        double sum = 0;
        foreach (Motor motor in motors)
        {
            if (motor.Brand == brandName)
            {
                sum += motor.PriceInEur;
            }
        }
        return Convert.ToInt32(sum);
    }



    public void Sort()
    {
        motors.Sort((x, y) => x.PriceInEur.CompareTo(y.PriceInEur));
    }
}
