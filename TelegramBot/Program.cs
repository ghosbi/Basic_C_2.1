using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Text;
using Telegram.Bot;
using TelegramBot.Configuration;
using TelegramBot.Controller;
using TelegramBot.Services;

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
            AppSettings appSettings = BuildAppSettings();
            services.AddSingleton(BuildAppSettings());

            //Подключаем контроллеры сообщений и кнопок
            services.AddTransient<DefaultMessageController>();
            services.AddTransient<VoiceMessageController>();
            services.AddTransient<TextMessageController>();
            services.AddTransient<InlineKeyboardController>();

            //Регистрируем хранилище сессий
            services.AddSingleton<IStorage, MemoryStorage>();
            // Регестрируем загрузку файлов
            services.AddSingleton<IFileHandler, AudioFileHadnler>();
            //Регистрируем объект TelegramBotClient
            services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient(appSettings.BotToken));
            //Регистрируем постоянно активный сервис бота
            services.AddHostedService<Bot>();

        }
        static AppSettings BuildAppSettings()
        {
            return new AppSettings()
            {
                DownloadFolder = "C:\\Users\\Pavel\\Downloads",
                BotToken = "6364439783:AAH-Z6w8t3fOTvBb09ikQ1hPernrrpc_9yI",
                AudioFileName = "audio1",
                InputAudioFormat = "ogg",
                OutputAudioFormat = "wav",
                InputAudioBitrate = 72000,
            };
        }

    }
}