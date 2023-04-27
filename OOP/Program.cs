using System; // Подключенное пространство имен
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            
        }

        static Department GetCurrentDepartment()
        {

        }

        static void tasksubTask()
        {
            var department = GetCurrentDepartment();

            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Сантк-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
        }

       
    }

    
}

class Pen
{
    public string color;
    public int cost;

    public void ShowConsole()
    {
        Console.WriteLine("{0} Ручка стоит {1}", color, cost);
    }
    public Pen()
    {
        color = "Черный";
        cost = 100;
    }
    public Pen(string penColor, int penCost)
    {
        color = penColor;
        cost = penCost;
    }
}

class Rectangle
{
    public int a;
    public int b;


    public int Square()
    {
        return a * b;

    }

    public Rectangle()
    {
        a = 6;
        b = 4;
    }
    public Rectangle(int c, int d)
    {
        a = c;
        b = d;
    }
    public Rectangle(int x)
    {
        a = x;
        b = x;
    }
}

class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name;
}

class bus
{
    public int? Load;

    public void PrintStatus()
    {
        if (Load.HasValue)
        {
            Console.WriteLine("В автобусе {0} пассажиров", Load.Value);
        }
        else
        {
            Console.WriteLine("Автобус пуст!");
        }
    }
}

class Triangle
{
    public int a;
    public int b;
    public int c;

    public double Square()
    {

    }

    public double Perimeter()
    {

    }
}

class Square
{
    public int side;

    public double Square()
    {

    }

    public double Perimeter()
    {

    }
}

class Circle
{
    public double radius;

    public double Square()
    {

    }

    public double Length()
    {

    }
}