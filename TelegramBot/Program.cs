using System;

namespace TelegramBot
{
    class Bot
    {
        /// <summary>
        /// объект, отвеающий за отправку сообщений клиенту
        /// </summary>
        private TelegramBotClient _telegramClient;

        public Bot(TelegramBotClient telegramClient)
        {
            _telegramClient = telegramClient;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            _telegramClient.OnMessage += HandleMessage;
            _telegramClient.OnMessage += HandleButtonClick;

            Console.WriteLine("Bot started");
        }

        /// <summary>
        /// Обработчик входящих тектовых сообщений  
        /// </summary>
        private async Task HandleMessage(object sender, MessageEventArgs e)
        {
            // Бот получил входящее сообщение пользователя
            var messageText = e.Message.Text;

            // Бот Отправляет ответ
            _telegramClient.SendTextMessage(e.ChatId, "Ответ на сообщение пользователя")
        }

        /// <summary>
        /// Обработчик нажатий на кнопки
        /// </summary>
        private async Task HandleButtonClick(object sender, MessageEventArgs e)
        {
        }
    }
}