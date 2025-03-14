namespace motors;

internal class Motor
{
    private string brand;
    private string name;
    private int releaseYear;
    private double performance;
    private double priceInEur;

    public global::System.String Brand { get => brand; }
    public global::System.String Name { get => name; }
    public global::System.Int32 ReleaseYear { get => releaseYear; }
    public global::System.Double Performance { get => performance; }
    public global::System.Double PriceInEur { get => priceInEur; }


    public Motor(string brand, string name, int releaseYear, double performance, double priceInEur)
    {
        this.brand = brand;
        this.name = name;
        this.releaseYear = releaseYear;
        this.performance = performance;
        this.priceInEur = priceInEur;
    }


}
