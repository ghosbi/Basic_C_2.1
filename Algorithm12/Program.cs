namespace Algorithm12
{
    class Program // Объявление класса Program
    {
        public static async Task Main()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            string greetings = "Привет" + name;
            Console.WriteLine(greetings);
        }
    }
}
