namespace Algorithm12
{
    class Program // Объявление класса Program
    {
        public static async Task Main()
        {
            Console.WriteLine("Сколько элементов будет в массиве?");

            var count = Int32.Parse(Console.ReadLine());
            var array = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите все {count} элемнтов");
                array[i] = Int32.Parse(Console.ReadLine());

            }
            Console.WriteLine("Все элементы записаны");
        }
        
        static void Task12_1_2()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            string greetings = "Привет, " + name;
            Console.WriteLine(greetings);
        }
    }
}
