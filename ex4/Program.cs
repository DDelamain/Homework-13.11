using System;
class Website
{
    private string name;
    private string url;
    private string description;
    private string ip;

    public void InputData()
    {
        Console.Write("Введите название сайта: ");
        name = Console.ReadLine();

        Console.Write("Введите путь к сайту : ");
        url = Console.ReadLine();

        Console.Write("Введите описание сайта: ");
        description = Console.ReadLine();

        Console.Write("Введите IP-адрес сайта: ");
        ip = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("\nИнформация о сайте:");
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"URL: {url}");
        Console.WriteLine($"Описание: {description}");
        Console.WriteLine($"IP-адрес: {ip}");
    }

    public string GetName() => name;
    public string GetUrl() => url;
    public string GetDescription() => description;
    public string GetIp() => ip;

    public void SetName(string value) => name = value;
    public void SetUrl(string value) => url = value;
    public void SetDescription(string value) => description = value;
    public void SetIp(string value) => ip = value;
}

class Program
{
    static void Main()
    {
        Website site = new Website();

        site.InputData();
        site.DisplayData();

        Console.WriteLine("\nДоступ к полям через методы:");
        Console.WriteLine($"Название: {site.GetName()}");
        Console.WriteLine($"IP: {site.GetIp()}");

        site.SetName("Google");
        Console.WriteLine($"\nПосле изменения: {site.GetName()}");
    }
}