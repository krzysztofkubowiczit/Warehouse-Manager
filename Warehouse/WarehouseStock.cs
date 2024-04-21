using System;
using System.Collections.Generic;
using Warehouse;


public class WarehouseStock
{
    private List<WarehouseItem> items = new List<WarehouseItem>();
    public List<WarehouseItem> Items => items;

    public void AddItem(string name, int quantity)
    {
        items.Add(new WarehouseItem { Name = name, Quantity = quantity });
    }

    public void RemoveItem(string name, int quantityToRemove)
    {
        var item = items.Find(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        
        if (item != null)
        {
            
            if (item.Quantity == quantityToRemove)
            {
                items.Remove(item);
            }
            
            else
            {
                item.Quantity -= quantityToRemove;
            }
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Obecny stan magazynu:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name}: {item.Quantity}");
        }
    }
}
