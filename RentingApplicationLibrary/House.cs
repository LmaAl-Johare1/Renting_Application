namespace RentingApplicationLibrary
{
    public class House : Building
    {
        public bool HasGarden { get; private set; }

        public House(string address, string name, double size, bool hasGarden)
            : base(address, name, size)
        {
            HasGarden = hasGarden;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"House: {Name}, Address: {Address}, Size: {Size} cm, Garden: {HasGarden}");
        }
    }
}
