using System; // Подключенное пространство имен
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {

            
            Console.WriteLine(EnterUser());
        }

        static (string name, string secondName, int age, string[] ArrayNamePit,int SumPet,bool havePit,int SumColor, string[] favoriteColor) EnterUser()
        {
            (string name, string secondName, int age, string[] ArrayNamePit,int SumPet,bool havePit,int SumColor, string[] favoriteColor) User;

            Console.WriteLine("Доброго времени суток, сейчас мы составим Анкету, будут необходимы следующие данные:\nВведиет Ваше Имя:");
            User.name = Console.ReadLine();

            Console.WriteLine("Введиет вашу Фамилию:");
            User.secondName = Console.ReadLine();

            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами");
                age = Console.ReadLine();

            } while (CheckNum(age, out intage));

            User.age = intage;

            Console.WriteLine("Есть ли у вас домашнее животное?");
            var havePit = Console.ReadLine();

            if (havePit == "Да")
            {
                User.havePit = true;
            }
            else
            {
               User.havePit = false;
            }

            string Pet;
            int numpet;
            if (User.havePit == true)
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


            return User;



        }
        static string[] ShowColor(int numcolor)
        {
            string[] ArrayFavoriteColor = new string[numcolor];
            for (int i = 0; i < numcolor; i++)
            {
                Console.WriteLine($"Введите любимый {i+1} цвет");
                ArrayFavoriteColor[i] = Console.ReadLine();
            }
            return ArrayFavoriteColor;

        }
        static string[] ShoePet(int numpet)
        {
            string[] ArrayNamePit = new string[numpet];
            for (int i = 0; i < numpet; i++)
            {
                Console.WriteLine($"Введите имя питома {i+1}");
                ArrayNamePit[i] = Console.ReadLine();
            }
            return ArrayNamePit;
        }
        static bool CheckNum(string number, out int corrnumber)
        {
            corrnumber = 0;
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
                else if (intnum == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                corrnumber = 0;
                return true;
            }
        }
        

    }
}