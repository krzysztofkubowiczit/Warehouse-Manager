Aplikacja do zarządzania magazynem i towarami w restauracji

Opis:
Prosta aplikacja konsolowa w C# do zarządzania magazynem i towarami w restauracji. Zawiera cztery klasy: WarehouseItem, WarehouseStock, Program oraz WarehouseStock.UnitTests

Klasy:

WarehouseItem: Reprezentuje pojedynczy element w magazynie, zawiera właściwości Name (nazwa produktu) i Quantity (ilość).
Warehouse: Zarządza magazynem, umożliwia dodawanie, usuwanie i wyświetlanie stanu magazynu.
Program: Główna klasa programu obsługująca interakcję z użytkownikiem w konsoli.
WarehouseStock.UnitTests Zawiera testy jednostkowe dla klasy WarehouseStock.
Funkcjonalności:

Sprawdzenie obecnego stanu magazynu.
Usunięcie elementów z magazynu.
Dodanie elementów do magazynu.
Testy jednostkowe:

Test_AddItem: Sprawdza czy dodawanie elementów do magazynu działa poprawnie.
Test_RemoveItem: Sprawdza czy usuwanie elementów z magazynu działa poprawnie.
Test_DisplayInventory: Sprawdza czy wyświetlanie stanu magazynu nie powoduje błędów.
Zastosowano framework NUnit do testów jednostkowych. Każdy test sprawdza jedną funkcjonalność aplikacji. Wszystkie testy są umieszczone w klasie WarehouseStock.UnitTests