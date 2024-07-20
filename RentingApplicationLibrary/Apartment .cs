namespace RentingApplicationLibrary
{
    public class Apartment : Building
    {
        public int FloorNumber { get; private set; }

        public Apartment(string address, string name, double size, int floorNumber)
            : base(address, name, size)
        {
            FloorNumber = floorNumber;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Apartment: {Name}, Address: {Address}, Size: {Size} sqm, Floor: {FloorNumber}");
        }
    }
}
