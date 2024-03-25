using System;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency(5);

        Car car = new Car("Civic", "Honda", 2020, 50.00m, 5, "V6", "Automatic", false);
        Truck truck = new Truck("F-150", "Ford", 2019, 80.00m, 3, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2021, 30.00m, 1000, "Gasoline", true);

        agency.AddVehicleToInventory(car, 0);
        agency.AddVehicleToInventory(truck, 1);
        agency.AddVehicleToInventory(motorcycle, 2);

        agency.DisplayInventory();

        agency.RentVehicle(1);

        agency.DisplayInventory();
        Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");
    }
}
