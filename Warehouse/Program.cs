using System;

class Program
{
    static void Main(string[] args)
    {
        WarehouseStock warehouse = new WarehouseStock();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Sprawdź stan magazynu");
            Console.WriteLine("2. Dodaj nowy produkt do magazynu");
            Console.WriteLine("3. Usuń produkt z magazynu");
            Console.WriteLine("4. Wyjdź");

            Console.Write("Wybierz opcję: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    warehouse.DisplayInventory();
                    break;
                case "2":
                    Console.Write("Podaj nazwę produktu: ");
                    string name = Console.ReadLine();
                    Console.Write("Podaj ilość: ");
                    int quantity;
                    while (!int.TryParse(Console.ReadLine(), out quantity))
                    {
                        Console.WriteLine("Nieprawidłowa ilość, spróbuj ponownie.");
                        Console.Write("Podaj ilość: ");
                    }
                    warehouse.AddItem(name, quantity);
                    Console.WriteLine("Produkt został dodany do magazynu.");
                    break;
                case "3":
                    Console.Write("Podaj nazwę produktu do usunięcia: ");
                    string itemToRemove = Console.ReadLine();
                    var item = warehouse.Items.Find(i => i.Name.Equals(itemToRemove, StringComparison.OrdinalIgnoreCase));
                    if (item != null)
                    {
                        Console.WriteLine($"Aktualna ilość produktu \"{item.Name}\" w magazynie: {item.Quantity}");
                        Console.Write("Podaj ilość do usunięcia (podaj taką samą lub mniejszą ilość): ");
                        int quantityToRemove;
                        while (!int.TryParse(Console.ReadLine(), out quantityToRemove) || quantityToRemove > item.Quantity)
                        {
                            if (quantityToRemove > item.Quantity)
                            {
                                Console.WriteLine($"Nie ma wystarczającej ilości produktu \"{item.Name}\" w magazynie.");
                                Console.WriteLine($"Aktualna ilość: {item.Quantity}");
                            }
                            Console.Write("Podaj ilość do usunięcia (podaj taką samą lub mniejszą ilość): ");
                        }
                        warehouse.RemoveItem(itemToRemove, quantityToRemove);
                        Console.WriteLine($"Usunięto {quantityToRemove} sztuk produktu \"{itemToRemove}\" z magazynu.");
                    }
                    else
                    {
                        Console.WriteLine($"Produkt o nazwie \"{itemToRemove}\" nie istnieje w magazynie.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Dziękujemy, do widzenia!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja, spróbuj ponownie.");
                    break;
            }
        }
    }
}
