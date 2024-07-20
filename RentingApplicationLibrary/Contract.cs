namespace RentingApplicationLibrary
{
    public class Contract
    {
        private readonly Customer _customer;
        private readonly Building _building;
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;
        private readonly double _price;
        public double Price
        {
            get => _price;
        }
        public Contract(Customer customer, Building building, DateTime startDate, DateTime endDate, double price)
        {
            _customer = customer;
            _building = building;
            _startDate = startDate;
            _endDate = endDate;
            _price = price;
        }

        public void DisplayContract()
        {
            Console.WriteLine($"Customer: {_customer.Name}");
            Console.WriteLine($"Building: {_building.Name}");
            Console.WriteLine($"Address: {_building.Address}");
            Console.WriteLine($"Size: {_building.Size} cm");
            Console.WriteLine($"Rental Period: {_startDate.ToShortDateString()} to {_endDate.ToShortDateString()}");
            Console.WriteLine($"Price: {_price:C}");
        }
    }
}
