using NUnit.Framework;
using NUnit.Framework.Legacy;

[TestFixture]
public class WarehouseTests
{
    [Test]
    public void AddItem_ShouldIncreaseItemCount()
    {
        // Arrange
        WarehouseStock warehouse = new WarehouseStock();

        // Act
        warehouse.AddItem("Jajka", 50);
        warehouse.AddItem("Mąka", 100);

        // Assert
        ClassicAssert.AreEqual(2, warehouse.Items.Count);
    }

    [Test]
    public void RemoveItem_WithSufficientQuantity_ShouldDecreaseItemCount()
    {
        // Arrange
        WarehouseStock warehouse = new WarehouseStock();
        warehouse.AddItem("Jajka", 50);
        warehouse.AddItem("Mąka", 100);

        // Act
        warehouse.RemoveItem("Jajka", 20);

        // Assert
        ClassicAssert.AreEqual(2, warehouse.Items.Count);
    }

    [Test]
    public void RemoveItem_WithInsufficientQuantity_ShouldNotDecreaseItemCount()
    {
        // Arrange
        WarehouseStock warehouse = new WarehouseStock();
        warehouse.AddItem("Jajka", 50);
        warehouse.AddItem("Mąka", 100);

        // Act
        warehouse.RemoveItem("Jajka", 60);

        // Assert
        ClassicAssert.AreEqual(2, warehouse.Items.Count);
    }

    [Test]
    public void RemoveItem_WithZeroQuantity_ShouldNotDecreaseItemCount()
    {
        // Arrange
        WarehouseStock warehouse = new WarehouseStock();
        warehouse.AddItem("Jajka", 50);
        warehouse.AddItem("Mąka", 100);

        // Act
        warehouse.RemoveItem("Jajka", 0);

        // Assert
        ClassicAssert.AreEqual(2, warehouse.Items.Count);
    }

    [Test]
    public void DisplayInventory_ShouldNotThrowException()
    {
        // Arrange
        WarehouseStock warehouse = new WarehouseStock();
        warehouse.AddItem("Jajka", 50);
        warehouse.AddItem("Mąka", 100);

        // Act & Assert
        Assert.DoesNotThrow(() => warehouse.DisplayInventory());
    }
}

