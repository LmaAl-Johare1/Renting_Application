namespace RentingApplicationLibrary
{
    public class Customer
    {
        public string Name { get; private set; }
        public List<Building> RentedBuildings { get; private set; }

        public Customer(string name)
        {
            Name = name;
            RentedBuildings = new List<Building>();
        }

        public void RentBuilding(Building building)
        {
            RentedBuildings.Add(building);
        }
    }
}
