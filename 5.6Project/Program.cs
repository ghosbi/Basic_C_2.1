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

        static (string name, string secondName, int age, string[] ArrayNamePit,int SumPet,string havePit,int SumColor, string[] favoriteColor) EnterUser()
        {
            (string name, string secondName, int age, string[] ArrayNamePit, int SumPet, string havePit, int SumColor, string[] favoriteColor) User;
            string name1;
            do
            {

                Console.WriteLine("Доброго времени суток, сейчас мы составим Анкету, будут необходимы следующие данные:\nВведите Ваше Имя:");

                name1 = Console.ReadLine();
            } while (CheckChar(name1, out _));

            User.name = name1;

            string name2;
            do
            {
                Console.WriteLine("Введиет вашу Фамилию:");
                name2 = Console.ReadLine();


            } while (CheckChar(name2, out _));

            User.secondName = name2;
            
            string age;
            int intage;
            bool havePit1 = false;
            do
            {
                Console.WriteLine("Введите возраст цифрами");
                age = Console.ReadLine();

            } while (CheckNum(age, out intage));

            User.age = intage;

            Console.WriteLine("Есть ли у вас домашнее животное?");
            var havePit = Console.ReadLine();

            if (havePit == "Да" || havePit == "да")
            {
                havePit1 = true;
                User.havePit = "Есть домашнии животные";
            }
            else
            {
               User.havePit = "Нету домашнего животного";
            }

            string Pet;
            int numpet;
            if (havePit1 == true)
            {
                do
                {
                    Console.WriteLine("Введите кол-во ваших домашних животных");
                    Pet = Console.ReadLine();
                } while (CheckNum(Pet, out numpet));


                User.SumPet = numpet;


                User.ArrayNamePit = ShoePet(numpet);

            }
            else
            {
                string[] outPet = {"нету", "питомцев"};
                User.SumPet = 0;
                User.ArrayNamePit = outPet;
            }

            string color;
            int numColor;
            do
            {
                Console.WriteLine("Введите кол-во любимых цветов");
                color = Console.ReadLine();
            } while (CheckNum(color, out numColor));

            User.SumColor = numColor;

            User.favoriteColor = ShowColor(numColor);

            Console.WriteLine("Ваше имя: {0}", User.name);
            Console.WriteLine("Ваша Фамилия: {0}", User.secondName);
            Console.WriteLine("Ваш возраст: {0}", User.age);
            Console.WriteLine(User.havePit);
            if (havePit1 == true)
            {
                Console.Write("Имена ваших животных: ");
                foreach (var name in User.ArrayNamePit)
                {
                    Console.Write(name + ", ");
                }
                Console.WriteLine();
            }
            Console.Write("Ваши любмые цвета:");
            foreach (var color1 in User.favoriteColor)
            {
                Console.Write(color1);
            }
            

            return User;
            

            

        }
        static string[] ShowColor(int numcolor)
        {
            string[] ArrayFavoriteColor = new string[numcolor];
            for (int i = 0; i < numcolor; i++)
            {
                do
                {
                    Console.WriteLine($"Введите любимый {i + 1} цвет");
                    ArrayFavoriteColor[i] = Console.ReadLine();
                } while (CheckChar(ArrayFavoriteColor[i], out _));
                
            }
            return ArrayFavoriteColor;

        }
        static string[] ShoePet(int numpet)
        {
            string[] ArrayNamePit = new string[numpet];
            for (int i = 0; i < numpet; i++)
            {
                do
                {
                    Console.WriteLine($"Введите имя питома {i + 1}");
                    ArrayNamePit[i] = Console.ReadLine();
                } while (CheckChar(ArrayNamePit[i], out _));
                
            }
            return ArrayNamePit;
        }
        static bool CheckNum(string number, out int corrnumber)
        {
            corrnumber = 0;
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0 && intnum <= 100)
                {
                    corrnumber = intnum;
                    return false;
                }
                else if (intnum == 0)
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
                corrnumber = 0;
                return true;
            }
        }
        static bool CheckChar(string number, out int corrnumber)
        {
            corrnumber = 0;
            if (int.TryParse(number, out int intnum))
            {
                Console.WriteLine("Вы ввели число");
                return true;
            }
            else
            {

                corrnumber = 0;
                return false;
            }
        }



    }
}