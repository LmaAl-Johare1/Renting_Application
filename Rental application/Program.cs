using RentingApplicationLibrary;
using System;

public class Program
{
    private static void Main()
    {
        Console.WriteLine("Welcome to the Renting Application!");

        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();
        var customer = new Customer(customerName);

        Building building = SelectBuilding();

        if (building == null)
        {
            Console.WriteLine("Invalid building selection.");
            return;
        }

        customer.RentBuilding(building);

        var contract = CreateContract(customer, building);
        if (contract == null)
        {
            Console.WriteLine("Failed to create contract.");
            return;
        }

        contract.DisplayContract();

        IPayment paymentMethod = SelectPaymentMethod();
        if (paymentMethod == null)
        {
            Console.WriteLine("Invalid payment method selection.");
            return;
        }

        paymentMethod.ProcessPayment(contract.Price);

        Console.WriteLine("Thank you for using the Renting Application!");
    }

    private static Building SelectBuilding()
    {
        Console.WriteLine("Select the type of building to rent:");
        Console.WriteLine("1. Apartment");
        Console.WriteLine("2. House");
        Console.WriteLine("3. Shop");
        int buildingType;
        if (!int.TryParse(Console.ReadLine(), out buildingType))
        {
            return null;
        }

        Console.Write("Enter address: ");
        string address = Console.ReadLine();
        Console.Write("Enter name of the building: ");
        string buildingName = Console.ReadLine();
        Console.Write("Enter size of the building (in cm): ");
        double size;
        if (!double.TryParse(Console.ReadLine(), out size))
        {
            return null;
        }

        switch (buildingType)
        {
            case 1:
                Console.Write("Enter floor number for the apartment: ");
                int floorNumber;
                if (int.TryParse(Console.ReadLine(), out floorNumber))
                {
                    return new Apartment(address, buildingName, size, floorNumber);
                }
                break;
            case 2:
                Console.Write("Does the house have a garden? (yes/no): ");
                bool hasGarden = Console.ReadLine().ToLower() == "yes";
                return new House(address, buildingName, size, hasGarden);
            case 3:
                Console.Write("Enter number of floors for the shop: ");
                int numberOfFloors;
                if (int.TryParse(Console.ReadLine(), out numberOfFloors))
                {
                    return new Shop(address, buildingName, size, numberOfFloors);
                }
                break;
        }

        return null;
    }

    private static Contract CreateContract(Customer customer, Building building)
    {
        Console.Write("Enter rental start date (yyyy-mm-dd): ");
        DateTime startDate;
        if (!DateTime.TryParse(Console.ReadLine(), out startDate))
        {
            return null;
        }

        Console.Write("Enter rental end date (yyyy-mm-dd): ");
        DateTime endDate;
        if (!DateTime.TryParse(Console.ReadLine(), out endDate))
        {
            return null;
        }

        Console.Write("Enter rental price: ");
        double price;
        if (!double.TryParse(Console.ReadLine(), out price))
        {
            return null;
        }

        return new Contract(customer, building, startDate, endDate, price);
    }

    private static IPayment SelectPaymentMethod()
    {
        Console.WriteLine("Select payment method:");
        Console.WriteLine("1. PayPal");
        Console.WriteLine("2. Credit Card");
        int paymentMethodChoice;
        if (!int.TryParse(Console.ReadLine(), out paymentMethodChoice))
        {
            return null;
        }

        switch (paymentMethodChoice)
        {
            case 1:
                return new PayPalPayment();
            case 2:
                return new CreditCardPayment();
            default:
                return null;
        }
    }
}
