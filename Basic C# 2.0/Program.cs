using System; // Подключенное пространство имен
using System.Threading.Channels;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            
        }
        static decimal Factorial(int x)
        {
           
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
                
            }
            
        }
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;

                }
                else
                {
                    return N*PowerUp(N,--pow);
                }
            }
        }
        static void Task554()
        {
            Console.WriteLine("Напишите что-нибудь");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите длину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.ReadKey();
        }
        static void Echo(string phrase, int deep)
        {
            var modif = phrase;
            if (modif.Length>2)
            {
                modif = modif.Remove(0, 2);
                
                
            }
                Console.BackgroundColor = (ConsoleColor)deep;
                Console.WriteLine("....." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);

            }
        }
        static void Task5313()
        {
            int[] sortedasc;
            int[] sorteddesc;


            var num = Convert.ToInt32(Console.ReadLine());

            SortArrey(GetArrayFromConsole(ref num), out sortedasc, out sorteddesc);
            foreach (var item in sorteddesc)
            {
                Console.WriteLine(item);

            }
            foreach (var item in sortedasc)
            {
                Console.WriteLine(item);
            }
        }
        static void Trash()
        {
            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);

            Console.WriteLine(arr[0]);
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
                

            }
            Console.WriteLine("Ваш массив");
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        }
        static int[] GetArrayFromConsole(ref int num)
        {
            
            var array = new int[num];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }
        static void SortArrey(int[] array, out int[] sorteddesc, out int[] sortedasc)
        {

            sortedasc = SortArrayAsc(array);
            sorteddesc = SortArrayDesc(array);

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
        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }
        static void ChangeAge(int age1)
        {
            Console.WriteLine("Введите возраст");
            int age2 = Convert.ToInt32(Console.ReadLine());
        }
        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }
        static int[] SortArrayDesc(int[] array)
        {
            int[] arrayCopy = new int[array.Length];
            int temp = 0;
            Array.Copy(sourceArray: array, destinationArray: arrayCopy, array.Length);
            for (int i = 0; i < arrayCopy.Length; i++)
            {
                for (int j = 0; j < arrayCopy.Length; j++)
                {
                    if (arrayCopy[i] > arrayCopy[j])
                    {
                        temp = arrayCopy[i];
                        arrayCopy[i] = arrayCopy[j];
                        arrayCopy[j] = temp;
                    }
                }
            }
            return arrayCopy;
        }
        static int[] SortArrayAsc(int[] array)
        {
            int temp = 0;
            int[] arrayCopy = new int[array.Length];
            Array.Copy(sourceArray: array, destinationArray: arrayCopy, array.Length);
            for (int i = 0; i < arrayCopy.Length; i++)
            {
                for (int j = 0; j < arrayCopy.Length; j++)
                {
                    if (arrayCopy[i] < arrayCopy[j])
                    {
                        temp = arrayCopy[i];
                        arrayCopy[i] = arrayCopy[j];
                        arrayCopy[j] = temp;
                    }
                }
            }
            return arrayCopy;
        }
    }
}
