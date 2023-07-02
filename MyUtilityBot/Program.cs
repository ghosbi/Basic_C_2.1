using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyUtilityBot;
using System.Text;
using Telegram.Bot;

namespace TelegramBot
{
    class Program // Объявление класса Program
    {
        public static async Task Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            //Объетк, отвечающий за постоянный жизненный цикл приложения
            var host = new HostBuilder()
                .ConfigureServices((hostContext, services) => ConfigureServices(services)) //Задаем конфигурацию
                .UseConsoleLifetime() //Позволяет поддерживать приложение активным в консоли
                .Build();
            Console.WriteLine("Сервис Запущен");
            //Запускаем сервис
            await host.RunAsync();
            Console.WriteLine("Сервис остановлен");

        }
        static void ConfigureServices(IServiceCollection services)
        {
            //Регистрируем объект TelegramBotClient
            services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient("6357173227:AAGAxiZA5VJeSGNN6DJnJq_tSU6aVoTf_hg"));
            //Регистрируем постоянно активный сервис бота
            services.AddHostedService<Bot>();

        }

    }
}