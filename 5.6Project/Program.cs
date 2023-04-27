using System; // Подключенное пространство имен
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {

            EnterUser();

        }

        static (string Name, string SecondName, int Age, string[] ArrayNamePit, int SumPet, string HavePit, int SumColor, string[] FavoriteColor) EnterUser()
        {
            (string Name, string SecondName, int Age, string[] ArrayNamePit, int SumPet, string HavePit, int SumColor, string[] FavoriteColor) User;
            string Name1;
            do
            {
                Console.WriteLine("Доброго времени суток, сейчас мы составим Анкету, будут необходимы следующие данные:\nВведите Ваше Имя:");
                Name1 = Console.ReadLine();

            } while (CheckChar(Name1, out _));

            User.Name = Name1;

            string Name2;
            do
            {
                Console.WriteLine("Введиет вашу Фамилию:");
                Name2 = Console.ReadLine();

            } while (CheckChar(Name2, out _));

            User.SecondName = Name2;

            string Age;
            int Intage;
            bool HavePit1 = false;
            do
            {
                Console.WriteLine("Введите возраст цифрами");
                Age = Console.ReadLine();

            } while (CheckNum(Age, out Intage));

            User.Age = Intage;

            Console.WriteLine("Есть ли у вас домашнее животное?");
            var HavePit = Console.ReadLine();

            if (HavePit == "Да" || HavePit == "да")
            {
                HavePit1 = true;
                User.HavePit = "Есть домашнии животные";
            }
            else
            {
                User.HavePit = "Нету домашнего животного";
            }

            string Pet;
            int Numpet;
            if (HavePit1 == true)
            {
                do
                {
                    Console.WriteLine("Введите кол-во ваших домашних животных");
                    Pet = Console.ReadLine();

                } while (CheckNum(Pet, out Numpet));

                User.SumPet = Numpet;

                User.ArrayNamePit = ShowPet(Numpet);

            }
            else
            {
                string[] OutPet = { "нету", "питомцев" };
                User.SumPet = 0;
                User.ArrayNamePit = OutPet;
            }

            string Color;
            int NumColor;
            do
            {
                Console.WriteLine("Введите кол-во любимых цветов");
                Color = Console.ReadLine();

            } while (CheckNum(Color, out NumColor));

            User.SumColor = NumColor;

            User.FavoriteColor = ShowColor(NumColor);

            Console.WriteLine("Ваше имя: {0}", User.Name);
            Console.WriteLine("Ваша Фамилия: {0}", User.SecondName);
            Console.WriteLine("Ваш возраст: {0}", User.Age);
            Console.WriteLine(User.HavePit);
            if (HavePit1 == true)
            {
                Console.Write("Имена ваших животных: ");
                foreach (var Name in User.ArrayNamePit)
                {
                    Console.Write(Name + ", ");
                }
                Console.WriteLine();
            }
            Console.Write("Ваши любмые цвета:");
            foreach (var Color1 in User.FavoriteColor)
            {
                Console.Write(Color1);
            }

            return User;

        }

        static string[] ShowColor(int Numcolor)
        {
            string[] ArrayFavoriteColor = new string[Numcolor];
            for (int i = 0; i < Numcolor; i++)
            {
                do
                {
                    Console.WriteLine($"Введите любимый {i + 1} цвет");
                    ArrayFavoriteColor[i] = Console.ReadLine();
                } while (CheckChar(ArrayFavoriteColor[i], out _));

            }
            return ArrayFavoriteColor;

        }

        static string[] ShowPet(int Numpet)
        {
            string[] ArrayNamePit = new string[Numpet];
            for (int i = 0; i < Numpet; i++)
            {
                do
                {
                    Console.WriteLine($"Введите имя питома {i + 1}");
                    ArrayNamePit[i] = Console.ReadLine();
                } while (CheckChar(ArrayNamePit[i], out _));

            }
            return ArrayNamePit;
        }

        static bool CheckNum(string Number, out int CorrNumber)
        {
            CorrNumber = 0;
            if (int.TryParse(Number, out int Intnum))
            {
                if (Intnum > 0 && Intnum <= 100)
                {
                    CorrNumber = Intnum;
                    return false;
                }
                else if (Intnum == 0)
                {
                    Console.WriteLine("Ошибка данных при вводе, значение не может быть равно 0");
                    return true;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное число");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод данных");
                CorrNumber = 0;
                return true;
            }
        }

        static bool CheckChar(string Number, out int CorrNumber)
        {
            CorrNumber = 0;
            if (int.TryParse(Number, out int Intnum))
            {
                Console.WriteLine("Вы ввели число");
                return true;
            }
            else
            {

                CorrNumber = 0;
                return false;
            }
        }



    }
}