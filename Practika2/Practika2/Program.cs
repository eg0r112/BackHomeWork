using System;
using System.Security.Cryptography.X509Certificates;

public class Animal
{
    public string Name;
    public Animal(string name)
    {
        Name = name;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} издает звук: ");
    }
}
public class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} издает звук: Гав-Гав");
    }
}
public class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} издает звук: Мяу-Мяу");
    }
}
public class Vehicle
{
    public int Speed, Passengers;
    public Vehicle(int speed, int passengers)
    {
        Speed = speed;
        Passengers = passengers;
    }
    public virtual void Move()
    {
        Console.WriteLine("Транспорт движется");
    }
}
public class Car : Vehicle
{
    public Car(int speed, int passengers) : base(speed, passengers){}
    public override void Move()
    {
        Console.WriteLine($"Машина едет со скоростью {Speed}км/ч и {Passengers} пассажирами");
    }
}
public class Bicycle : Vehicle
{
    public Bicycle(int speed, int passengers) : base(speed, passengers) { }
    public override void Move()
    {
        Console.WriteLine($"Велосипед едет со скоростью {Speed}км/ч и {Passengers} пассажиром");
    }
}
public class Empoloyee
{
    public string Name;
    public Empoloyee(string name)
    {
        Name = name;
    }
    public virtual int GetSalary()
    {
        return (int) 0;
    }
}
public class Manager:Empoloyee
{
    public Manager(string name) : base(name) { }
    public override int GetSalary()
    {
        return (int)50000;
    }
}
public class Developer:Empoloyee
{
    public int HoursWorked, HourlyRate;
    public Developer(string name, int hoursWorked, int hourlyRate) : base(name)
    {
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }
    public override int GetSalary()
    {
        return (int)HoursWorked * HourlyRate;
    }
}
public abstract class Shape
{
    public abstract double GetArea();
}
public class Circle : Shape 
{
    public int radius;
    public Circle(int Radius)
    {
        radius = Radius;
    }
    public override double GetArea()
    {
        return (double)3.14 * radius * radius;
    }
}
public class Rectangle : Shape 
{
    public int width, height;
    public Rectangle(int Width, int Height)
    {
        width = Width;
        height = Height;
    }
    public override double GetArea()
    {
        return (double)width * height;
    }
}
public class Material
{
    public string Title;
    public Material(string title)
    {
        Title = title;
    }
    public virtual void Display()
    {
        Console.WriteLine(Title);
    }
}
public class Book:Material
{
    public string Author;
    public Book(string title, string author) : base(title)
    {
        Author = author;
    }
    public override void Display()
    {
        Console.WriteLine($"{Title}-{Author}");
    }
}
public class Video:Material
{
    public double Duration;
    public Video(string title, double duration) : base(title)
    {
        Duration = duration;
    }
    public override void Display()
    {
        Console.WriteLine($"{Title}-{Duration}");
    }
}
public class Product
{
    public string Name;
    public Product(string name)
    {
        Name = name;
    }
    public virtual double GetPrice()
    {
        return 0;
    }
}
public class DigitalProduct : Product
{
    public double Price;
    public DigitalProduct(string name, double price) : base(name)
    {
        Price = price;
    }
    public override double GetPrice()
    {
        return (double) Price;
    }
}
public class PhysicalProduct : Product
{
    public double Price, ShippingCost;
    public PhysicalProduct(string name, double price, double shippingCost) : base(name)
    {
        Price = price;
        ShippingCost = shippingCost;
    }
    public override double GetPrice()
    {
        return (double)Price + ShippingCost;
    }
}
public class Program
{
    static void Main()
    {
        Console.WriteLine("\n\n Введите номер практики:");
        int number = Int32.Parse(Console.ReadLine());
        switch (number)
        {
            case 1:
                Animal[] animals = {new Dog("Собака"), new Cat("Кошка")};
                foreach (Animal animal in animals)
                {
                    animal.MakeSound();
                }
                Main();
                break;
            case 2:
                Vehicle[] vehicles = {new Car(100, 4), new Bicycle(25, 1), new Car(130, 2), new Car(200, 1)};
                foreach(Vehicle vehicle in vehicles)
                {
                    vehicle.Move();
                }
                Main();
                break;
            case 3:
                int summa = 0;
                Empoloyee[] empoloyees = {new Manager("Иван"), new Manager("Пётр"), new Manager("Вася"), new Developer("Григорий",20 ,2000), new Developer("Влад",10 ,1300), new Developer("Саша",15 ,2500)};
                foreach(Empoloyee empoloyee in empoloyees)
                {
                    Console.WriteLine($"Зарплата {empoloyee.Name}: {empoloyee.GetSalary()}");
                    summa += empoloyee.GetSalary();
                }
                Console.WriteLine($"Общая сумма зарплаты работникам состовляет: {summa}");
                Main();
                break;
            case 4:
                double Big = 0;
                int num = 1;
                int rec = 0;
                Shape[] shapes = {new Circle(10), new Circle(13), new Rectangle(10, 2), new Rectangle(20, 3)};
                foreach(Shape shape in shapes)
                {
                    if(Big<shape.GetArea())
                    {
                        Big = shape.GetArea();
                        rec = num;
                    }
                    Console.WriteLine($"{num}. {shape.GetArea()}см в квадрате");
                    num++;
                }
                Console.WriteLine($"фигура с большей площадью под номером {num} - {Big}см в квадрате");
                Main();
                break;
            case 5:
                Material[] materials = {new Book("Кареглазка","Арсланов"), new Book("Кукольный домик","Грушницкий"), new Video("Котики",1000), new Video("1+1",201)};
                foreach(Material material in materials)
                {
                    material.Display();
                }
                Main();
                break;
            case 6:
                double summ = 0;
                Product[] products = {new DigitalProduct("огурец",100), new PhysicalProduct("апельсин",102, 12), new PhysicalProduct("груша",12, 39)};
                foreach(Product product in products)
                {
                    summ += product.GetPrice();
                    Console.WriteLine($"{product.Name} - {product.GetPrice()}руб");
                }
                Console.WriteLine($"Сумма - {summ}руб");
                Main();
                break;
            default:
                break;
        }
    }
}