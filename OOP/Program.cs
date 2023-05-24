using System; // Подключенное пространство имен
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args)
        {

        }
    }


}

class Helper
{
    public static void Swap(ref int a,ref int b)
    {
        int c;
        c = a;
        a = b;
        b = c;
    }
}

class Obj2
{
    public string Name;
    public string Description;

    public static int MaxValue;
    public static string Parent;
    public static int DaysInWeek;

    static Obj2()
    {
        Console.WriteLine("Вызван статический конструктор класса Obj2");
        DaysInWeek = 7;
        Parent = "System.Object";
        MaxValue = 2000;
    }


}

abstract class ComputerPart
{
    public abstract void Work();

}

class Processor : ComputerPart
{
    public override void Work()
    {

    }
}

class MotherBoard : ComputerPart
{
    public override void Work()
    {

    }
}

class GraphicCard : ComputerPart
{
    public override void Work()
    {

    }
}

class IndexingClass
{
    private int[] array;

    public IndexingClass(int[] array)
    {
        this.array = array;
    }

    public int this[int index]
    {
        get
        {
            return array[index];

        }
        set
        {
            array[index] = value;
        }
    }
}

class Obj1
{
    public int Value;

    public static Obj1 operator +(Obj1 a, Obj1 b)
    {
        return new Obj1
        {
            Value = a.Value + b.Value
        };
    }
    public static Obj1 operator -(Obj1 a, Obj1 b)
    {
        return new Obj1
        {
            Value = a.Value - b.Value
        };
    }
}

class A
{
    public virtual void Display()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public void Display()
    {
        Console.WriteLine("B");
    }
}

class C : A
{
    public override void Display()
    {
        Console.WriteLine("C");
    }
}

class D : B
{
    public void Display()
    {
        Console.WriteLine("D");
    }
}

class E : C
{
    public void Display()
    {
        Console.WriteLine("E");
    }
}

class BaseClass
{
    protected string Name;

    public virtual int Counter1
    {
        get;
        set;
    }

    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
    public BaseClass(string name)
    {
        Name = name;
    }
}

class DerivedClass : BaseClass
{
    public string Description;

    public int Counter;

    private int counter1;
    public override int Counter1
    {
        get
        {
            return counter1;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Числа меньше 0 не заносятся");
            }
            else
            {
                counter1 = value;
            }
        }
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }
    public DerivedClass(string name, string description) : base(name)
    {
        Description = description;
    }

    public DerivedClass(string name, string description, int counter) : base(name)
    {
        Description = description;
        Counter = counter;
    }
}

class SmartHelper
{
    private string name;

    public SmartHelper(string name)
    {
        this.name = name;
    }

    public void Greetings(string name)
    {
        Console.WriteLine("Привет, {0}, я интеллектуальный помошник {1}", name, this.name);
    }
}

class Obj
{
    private string name;
    private string owner;
    private int length;
    private int count;

    public Obj(string name, string ownerName, int objLength, int count)
    {
        this.name = name;
        owner = ownerName;
        length = objLength;
        this.count = count;

    }
}

class ProjectManager : Employee
{
    public string ProjectName;
}

class Developer : Employee
{
    private string ProgrammingLanguage;
}

class User
{
    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть не меньше 18");
            }
            else
            {
                age = value;
            }
        }
    }

    private string login;

    public string Login
    {
        get
        {
            return login;
        }

        set
        {
            if (login.Length < 3)
            {
                Console.WriteLine("Логин должен быть больше 3 символов");
            }
            else
            {
                login = value;
            }
        }
    }

    private string mail;

    public string Mail
    {
        get
        {
            return mail;
        }

        set
        {
            if (mail.Contains('@'))
            {
                mail = value;
            }
            else
            {
                Console.WriteLine("Указан неверный mail");
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


}

class Circle
{
    public double radius;


}

class TrafficLight
{
    private void ChangeColor(string color)
    {

    }

    public void GetColor()
    {

    }
}

class Employee
{
    public string Name;
    public int Age;
    public int Salary;
}

class apple : Fruit
{

}

class banana : Fruit
{

}

class pear : Fruit
{

}

class potato : Vegetable
{

}

class Carrot : Vegetable
{

}

class Fruit : Food
{

}

class Vegetable : Food
{

}

class Food
{

}