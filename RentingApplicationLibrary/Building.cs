namespace RentingApplicationLibrary
{
    public abstract class Building
    {
        private string _address;
        private string _name;
        private double _size;

        public string Address
        {
            get => _address;
            private set => _address = value;
        }

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public double Size
        {
            get => _size;
            private set => _size = value;
        }

        protected Building(string address, string name, double size)
        {
            Address = address;
            Name = name;
            Size = size;
        }

        public abstract void DisplayDetails();
    }
}
