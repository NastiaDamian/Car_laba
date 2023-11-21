using System;

class Car
{
    public string Name;
    public string Color;
    public double Price;
    public const string CompanyName = "Company";

    
    public Car()
    {
    }

    public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

    
    public void Input()
    {
        Console.WriteLine("Введіть дані про автомобіль:");
        Console.Write("Назва: ");
        Name = Console.ReadLine();

        Console.Write("Колір: ");
        Color = Console.ReadLine();

        Console.Write("Ціна: ");
        if (double.TryParse(Console.ReadLine(), out double price))
        {
            Price = price;
        }
        else
        {
            Console.WriteLine("Некоректне значення для ціни.");
        }
    }

    
    public void Print()
    {
        Console.WriteLine($"Назва: {Name}, Колір: {Color}, Ціна: {Price}, Компанія: {CompanyName}");
    }

    
    public void ChangePrice(double x)
    {
        Price -= Price * (x / 100);
    }

    
    public void ChangeColor(string newColor)
    {
        if (!string.IsNullOrEmpty(newColor))
        {
            Color = newColor;
        }
        else
        {
            Console.WriteLine("Некоректний колір.");
        }
    }

    
    public string PrintInfo()
    {
        return $"Назва: {Name}, Колір: {Color}, Ціна: {Price}, Компанія: {CompanyName}";
    }
}

class Program
{
    static void Main()
    {
        
        Car car1 = new Car();
        Car car2 = new Car("Модель12", "Голубий", 30000);
        Car car3 = new Car();

        
        car1.Input();
        car3.Input();

        
        car1.ChangePrice(10);
        car2.ChangePrice(10);
        car3.ChangePrice(10);

        Console.WriteLine("Дані про автомобілі після зменшення ціни на 10%:");
        car1.Print();
        car2.Print();
        car3.Print();

        // Введення нового коліру та пофарбування авто з коліром white
        Console.Write("Введіть новий колір для авто з коліром white: ");
        string newColor = Console.ReadLine();

        if (car1.Color.ToLower() == "white")
        {
            car1.ChangeColor(newColor);
        }

        if (car2.Color.ToLower() == "white")
        {
            car2.ChangeColor(newColor);
        }

        if (car3.Color.ToLower() == "white")
        {
            car3.ChangeColor(newColor);
        }

        Console.WriteLine("Дані про автомобілі після зміни кольору:");
        car1.Print();
        car2.Print();
        car3.Print();

        
        Console.WriteLine("Інформація про авто в форматі рядка:");
        Console.WriteLine(car1.PrintInfo());
        Console.WriteLine(car2.PrintInfo());
        Console.WriteLine(car3.PrintInfo());
    }
}
