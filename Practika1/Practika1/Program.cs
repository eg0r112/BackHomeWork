using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
public class Car
{
    public string model;
    public string brend;
    public int year;

    public Car(string Model, string Brend, int Year)
    {
        model = Model;
        brend = Brend;
        year = Year;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"{model}, {brend}, {year}");
    }
}
public class Calculator
{
    public int Add(int A, int B) => A + B;
    public int Subtract(int A, int B) => A - B;
    public int Multiply(int A, int B)
    {
       return (int) A * B; 
    }
    public float Dividy(int A, int B)
    {
        if(B==0)
        {
            Console.WriteLine("НА 0 НЕ ДЕЛИ, ТЕБЯ КАК В ШКОЛЕ УЧИЛИ?!");
            return float.NaN;
        }
        else
        {
            return (float)A / B;
        }
    }
}
public class Book
{
    public string Nazv;
    public string Avtor;
    public int Pages;

    public Book(string nazv, string avtor, int pages)
    {
        Nazv = nazv;
        Avtor = avtor;
        Pages = pages;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"{Nazv}, {Avtor}, {Pages}");
    }
}
public class BankAccount
{

    public BankAccount(int AccountNumber, decimal Balance)
    {
        balance = Balance;
        accountNumber = AccountNumber;
    }
    public int accountNumber;
    public decimal balance;
    public void Deposit(decimal amount)
    {
        balance += amount;
    }
    public void Whithdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Недостаточно средств");
        }
        else
        {
            balance -= amount;
        }
    }
    public void ShowBalance()
    {
        Console.WriteLine($"{accountNumber}, {balance}");
    }
}
public class Product
{
    public string Name;
    public float Price;
    public int Quantity;
    public Product(string name, float price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    public float GetTotalCost()
    {
        return (float) Price * Quantity;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"{Price}, {Quantity}");
    }
}
public class Student
{
    public string name;
    public int age;
    public int[] grades;
    public Student(string name, int age, int[] grades)
    {
        this.name = name;
        this.age = age;
        this.grades = grades;
    }
    public double GetAverageGrade()
    {
        int n = grades.Length;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += grades[i];
        } return (double) sum/n;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"{name},{age},{GetAverageGrade()}");
    }
}
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine();
    }
}
public class Dog:Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Гав-Гав");
    }
}
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Мяу-Мяу");
    }
}
public class Cow : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Мууу");
    }
}
public abstract class Shape
{
    public abstract float GetArea();
}
public class Circle : Shape
{
    public float radius;
    public Circle(float Radius)
    {
        radius = Radius;
    }
    public override float GetArea()
    {
        return (float) 3.14 * radius* radius;
    }
}
public class Rectangle : Shape
{
    public float width;
    public float height;
    public Rectangle(float Width, float Height)
    {
        width = Width;
        height = Height;
    }
    public override float GetArea()
    {
        return (float) width * height;
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
                    Car myCar = new Car("Tayota", "bfbf", 2022);
                    myCar.ShowInfo();
                    Main();
                    break;
                case 2:
                    Calculator calc = new Calculator();
                    Console.WriteLine(calc.Add(2, 5));
                    Console.WriteLine(calc.Subtract(30, 5));
                    Console.WriteLine(calc.Multiply(20, 5));
                    Console.WriteLine(calc.Dividy(10, 5));
                    Main();
                    break;
                case 3:
                    Book bok = new Book("Avrora", "Naharova", 193);
                    bok.ShowInfo();
                    Main();
                    break;
                case 4:
                    BankAccount newBank = new BankAccount(10120, 201302);
                    Console.WriteLine("1.Положить \n 2.Снять \n 3.Информация");
                    int number1 = Int32.Parse(Console.ReadLine());
                    if (number1 == 1)
                    {
                        newBank.Deposit(200);
                    }
                    else if (number1 == 2)
                    {
                        newBank.Whithdraw(200);
                    }
                    else if (number1 == 3)
                    {
                        newBank.ShowBalance();
                    }
                    Main();
                    break;
                case 5:
                Product prod = new Product("ORANGE", 191, 129);
                    prod.ShowInfo();
                Main();
                    break;
                case 6:
                Student study = new Student("Egor", 15, new int[] {2, 5, 3, 4});
                study.ShowInfo();
                    Main();
                    break;
                case 7:
                Dog dog = new Dog();
                Cat cat = new Cat();
                Cow cow = new Cow();
                dog.MakeSound();
                cat.MakeSound();
                cow.MakeSound();
                Main();
                    break;
                case 8:
                Shape[] shapes = { new Circle(5), new Rectangle(4, 6) };
                foreach (Shape shape in shapes)
                    Console.WriteLine($"Площадь: {shape.GetArea()}");
                    Main();
                    break;
                default:
                    break;
            }
        }
    }
