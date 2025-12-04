using System;
class Shop
{
    private string name;
    private string address;
    private string profileDescription;
    private string phone;
    private string email;

    public void InputData()
    {
        Console.Write("Название магазина: ");
        name = Console.ReadLine();

        Console.Write("Адрес магазина: ");
        address = Console.ReadLine();

        Console.Write("Описание магазина: ");
        profileDescription = Console.ReadLine();

        Console.Write("Контактный телефон: ");
        phone = Console.ReadLine();

        Console.Write("Контактный e-mail: ");
        email = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("\nИнформация о магазине:");
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Адрес: {address}");
        Console.WriteLine($"Профиль: {profileDescription}");
        Console.WriteLine($"Телефон: {phone}");
        Console.WriteLine($"E-mail: {email}");
    }

    public string GetName() => name;
    public string GetAddress() => address;
    public string GetProfileDescription() => profileDescription;
    public string GetPhone() => phone;
    public string GetEmail() => email;

    public void SetName(string value) => name = value;
    public void SetAddress(string value) => address = value;
    public void SetProfileDescription(string value) => profileDescription = value;
    public void SetPhone(string value) => phone = value;
    public void SetEmail(string value) => email = value;
}

class Program
{
    static void Main()
    {
        Shop shop = new Shop();

        shop.InputData();
        shop.DisplayData();

        Console.WriteLine($"\nМагазин: {shop.GetName()}");
        Console.WriteLine($"Почта: {shop.GetEmail()}");

        shop.SetPhone("8 800 555-35-35");
        Console.WriteLine($"\nНовый телефон: {shop.GetPhone()}");
    }
}