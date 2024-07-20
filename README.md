# Renting Application

Welcome to the Renting Application! This application allows customers to rent different types of buildings (apartments, houses, shops) and provides functionalities to manage contracts and process payments.

## Features

- **Building Management**: Create and manage different types of buildings including apartments, houses, and shops.
- **Customer Management**: Add customers and associate them with rented buildings.
- **Contract Management**: Create and display rental contracts including rental period and price.
- **Payment Processing**: Process payments using different payment methods (PayPal, Credit Card).


## Object-Oriented Principles

This application demonstrates several key object-oriented programming (OOP) principles:

### 1. Inheritance
Inheritance allows classes to inherit fields and methods from other classes.
- **Example**: `Apartment`, `House`, and `Shop` classes inherit from the `Building` class.
    ```csharp
    public class Apartment : Building
    public class House : Building
    public class Shop : Building
    ```

### 2. Abstraction
Abstraction hides the complex implementation details and shows only the essential features.
- **Example**: The `Building` class is an abstract class that defines common properties and methods for all building types.
    ```csharp
    public abstract class Building
    ```

### 3. Polymorphism
Polymorphism allows methods to do different things based on the object it is acting upon.
- **Example**: The `DisplayDetails` method is overridden in `Apartment`, `House`, and `Shop` classes to provide specific details for each building type.
    ```csharp
    public override void DisplayDetails()
    ```

### 4. Aggregation
Aggregation is a special form of association where objects have their own lifecycle but there is ownership.
- **Example**: The `Customer` class aggregates `Building` objects in a list, indicating a customer can rent multiple buildings, and these buildings can exist independently of the customer.
    ```csharp
    public List<Building> RentedBuildings { get; set; } = new List<Building>();
    ```

### 5. Composition
Composition is a stronger form of aggregation where the lifecycle of the contained object depends on the lifecycle of the containing object.
- **Example**: The `Contract` class contains instances of `Customer` and `Building`, meaning a contract cannot exist without a customer and a building. If the contract is destroyed, the relationship it represents also ceases to exist.
    ```csharp
    private readonly Customer _customer;
    private readonly Building _building;
    ```

## Code Structure

- **`Program.cs`**: Entry point of the application, handles user interaction.
- **`Building.cs`**: Abstract base class for all building types.
- **`Apartment.cs`**, **`House.cs`**, **`Shop.cs`**: Concrete building classes inheriting from `Building`.
- **`Customer.cs`**: Class representing a customer.
- **`Contract.cs`**: Class representing a rental contract.
- **`IPayment.cs`**: Interface for payment processing.
- **`PayPalPayment.cs`**, **`CreditCardPayment.cs`**: Concrete classes implementing `IPayment`.

