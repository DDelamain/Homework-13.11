using System;
class Magazine
{
    private string title;
    private int foundingYear;
    private string description;
    private string phone;
    private string email;

    public void InputData()
    {
        Console.Write("Название журнала: ");
        title = Console.ReadLine();

        Console.Write("Год основания: ");
        foundingYear = int.Parse(Console.ReadLine());

        Console.Write("Описание журнала: ");
        description = Console.ReadLine();

        Console.Write("Контактный телефон: ");
        phone = Console.ReadLine();

        Console.Write("Контактный e-mail: ");
        email = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("\nИнформация о журнале:");
        Console.WriteLine($"Название: {title}");
        Console.WriteLine($"Год основания: {foundingYear}");
        Console.WriteLine($"Описание: {description}");
        Console.WriteLine($"Телефон: {phone}");
        Console.WriteLine($"E-mail: {email}");
    }

    public string GetTitle() => title;
    public int GetFoundingYear() => foundingYear;
    public string GetDescription() => description;
    public string GetPhone() => phone;
    public string GetEmail() => email;

    public void SetTitle(string value) => title = value;
    public void SetFoundingYear(int value) => foundingYear = value;
    public void SetDescription(string value) => description = value;
    public void SetPhone(string value) => phone = value;
    public void SetEmail(string value) => email = value;
}
class Program
{
    static void Main()
    {
        Magazine mag = new Magazine();
        mag.InputData();
        mag.DisplayData();

        Console.WriteLine($"\nЖурнал: {mag.GetTitle()}");
        Console.WriteLine($"Email: {mag.GetEmail()}");

        mag.SetPhone("+7 800 555 35 35");
        Console.WriteLine($"Новый телефон: {mag.GetPhone()}");
    }
}