using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.Configuration;
using TelegramBot.Services;

namespace TelegramBot.Controller
{
    public class VoiceMessageController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly AppSettings _appSettings;
        private readonly IFileHandler _audioFileHandler;

        public VoiceMessageController(ITelegramBotClient telegramBotClient, AppSettings appSettings, IFileHandler audioFileHandler)
        {
            _telegramClient = telegramBotClient;
            _appSettings = appSettings;
            _audioFileHandler = audioFileHandler;
        }
        public async Task Handle(Message message, CancellationToken ct)
        {
            Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
            var fileId = message.Voice?.FileId;
            if (fileId == null)
                return;

            await _audioFileHandler.Download(fileId, ct);

            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Голсоовое сообщение загружено", cancellationToken: ct);
        }
    }
}
