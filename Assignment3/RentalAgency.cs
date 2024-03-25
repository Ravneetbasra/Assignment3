using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RentalAgency
{
    private Vehicle[] Fleet { get; set; }
    public decimal TotalRevenue { get; private set; }

    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
    }

    public void AddVehicleToInventory(Vehicle vehicle, int index)
    {
        Fleet[index] = vehicle;
    }

    public void RemoveVehicleFromInventory(int index)
    {
        Fleet[index] = null;
    }

    public void RentVehicle(int index)
    {
        if (Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice;
            RemoveVehicleFromInventory(index);
            Console.WriteLine("Vehicle rented successfully.");
        }
        else
        {
            Console.WriteLine("No vehicle available at this index.");
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Current Inventory:");
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] != null)
            {
                Console.WriteLine($"Index: {i}");
                Fleet[i].DisplayDetails();
            }
        }
    }
}
