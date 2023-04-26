namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {

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