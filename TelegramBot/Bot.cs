using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TelegramBot
{
    internal class Bot
    {
        private ITelegramBotClient _telegramClient;

        public Bot(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = _telegramClient;
        }

        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Обрабатываем нажатия на кнопки из Telegram Bot API:https://core.telegram.org/bots/api#callbackquery
            if (update.Type == UpdateType.CallbackQuery)
            {
                await _telegramClient.SendTextMessageAsync(update.Message.Chat.Id, "Вы нажали кнопку", cancellationToken: cancellationToken);
                return;

            }
            //Обрабатываем входящее сообщение из Telegram Bot API: https://core.telegram.org/bots/api#message
            if (update.Type == UpdateType.Message)
            {
                await _telegramClient.SendTextMessageAsync(update.Message.Chat.Id, "Вы отправили сообщение", cancellationToken: cancellationToken);
                return;
            }
        }
    }
}
