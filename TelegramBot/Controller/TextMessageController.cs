using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot.Controller
{
    public class TextMessageController
    {
        private readonly ITelegramBotClient _telegramClient;

        public TextMessageController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
            switch(message.Text)
            {
                case "/start":
                    //Объект, представляющий кнопки
                    var buttons = new List<InlineKeyboardButton[]>();
                    buttons.Add(new[]
                    {
                        InlineKeyboardButton.WithCallbackData($"Русский", $"ru"),
                        InlineKeyboardButton.WithCallbackData($"English", $"en")
                    });
                    // передаем кнопки вместе с сообщением( параметр ReplyMarkup)
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"<b> Наш бот превращает аудио в текст.</b> {Environment.NewLine}" + 
                        $"{Environment.NewLine} " +
                        $"Можно записать сообщение и переслать другу, если лень печатать.{Environment.NewLine}", 
                        cancellationToken: ct, 
                        parseMode: Telegram.Bot.Types.Enums.ParseMode.Html, replyMarkup: new InlineKeyboardMarkup(buttons));
                    break;
                default:
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, "Отправьте аудио для превращения в текст.", cancellationToken: ct);
                    break;
            };
        }

    }
}
