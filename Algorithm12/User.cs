using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithm12.Program;

namespace Algorithm12
{
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public static void ToShowAds(List<User> listUser, EligibleToShowAds IsShowAdsEligible)
        {
            foreach (User user in listUser)
            {
                if (IsShowAdsEligible(user))
                {
                    Console.WriteLine();
                    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
                    //Остановка на 1 с
                    Thread.Sleep(1000);

                    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                    Thread.Sleep(2000);

                    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу");
                    Console.WriteLine("Реклама {0} показана", user.Name);
                    //Остановка на 3с
                    Thread.Sleep(3000);


                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("У {0} есть премиум, ему реклама не показана", user.Name);
                    //Остановка на 3с
                    Thread.Sleep(3000);
                }

            }


        }
    }
}
