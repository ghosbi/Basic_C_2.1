using static Algorithm12.Program;

namespace Algorithm12
{
    class Program // Объявление класса Program
    {
        public delegate bool EligibleToShowAds(User UserToShowAds);
        static void Main(string[] args)
        {
            User user1 = new User()
            {
                Login = "Ghosbi",
                Name = "Pavel",
                IsPremium = true
            };

            User user2 = new User()
            {
                Login = "Sannchi",
                Name = "Sasha",
                IsPremium = false
            };

            User user3 = new User()
            {
                Login = "Bircha",
                Name = "Alex",
                IsPremium = true
            };

            User user4 = new User()
            {
                Login = "Marki",
                Name = "Maria",
                IsPremium = false
            };

            List<User> listUser = new List<User>
            {
                user1,
                user2,
                user3,
                user4
            };

            EligibleToShowAds eligibleToShowAds = ShowAds;

            User.ToShowAds(listUser, eligibleToShowAds);



        }
        public static bool ShowAds(User user)
        {
            if (user.IsPremium == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        static void Task12_1_2()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            string greetings = "Привет, " + name;
            Console.WriteLine(greetings);
        }
        static void Tastk12_1_3()
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
        static void Task12_1_4()
        {
            Console.WriteLine("Введите свой возраст");

            var age = Int32.Parse(Console.ReadLine());
            if (age > 13)
            {
                Console.WriteLine("Вы успешно зарегистрированы");
            }
            else
            {
                Console.WriteLine("Пользователи младше 14 лет не могут быть зарегистрированы");
            }
        }

    }

}
