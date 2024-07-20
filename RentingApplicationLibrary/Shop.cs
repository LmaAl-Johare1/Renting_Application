namespace RentingApplicationLibrary
{
    public class Shop : Building
    {
        public int NumberOfFloors { get; private set; }

        public Shop(string address, string name, double size, int numberOfFloors)
            : base(address, name, size)
        {
            NumberOfFloors = numberOfFloors;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Shop: {Name}, Address: {Address}, Size: {Size} sqm, Floors: {NumberOfFloors}");
        }
    }
}
