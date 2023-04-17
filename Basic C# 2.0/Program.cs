using System; // Подключенное пространство имен
using System.Threading.Channels;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
           
            var array = GetArrayFromConsole(10);
            var sortedarray = SortArrey(array);
            ShowArray(array, true);


            Console.ReadKey();
        }
        static void Trash()
        {
            var (name, age) = ("Евгений", 27);
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите возраст цифрами:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }
            ShowColors(name, favcolors);
        }
        static void ShowArray(int[] array, bool isSort = false)
        {
            var temp = array;
            if (isSort)
            {
                temp = SortArrey(array);

            }
            Console.WriteLine("Ваш массив");
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        }
        static int[] GetArrayFromConsole(int num = 5)
        {
            
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static int[] SortArrey(int[] result)
        {

            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1} \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }
        static void ShowColors(string username = "Pavel", params string[] favcolors)
        {
            Console.WriteLine("{0}, Ваши любимые цвета:", username);
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
