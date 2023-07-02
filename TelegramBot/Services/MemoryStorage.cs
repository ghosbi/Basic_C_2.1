using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBot.Models;

namespace TelegramBot.Services
{
    public class MemoryStorage:IStorage
    {
        ///<summary>
        /// Хранилище сессий
        /// </summary>
        private readonly ConcurrentDictionary<long, Session> _sessions;

        public MemoryStorage()
        {
            _sessions = new ConcurrentDictionary<long, Session>();
        }
        
        public Session GetSession(long chatId)
        {
            //Возвращаем сессию по ключу, если она существуюет
            if (_sessions.ContainsKey(chatId))
                return _sessions[chatId];

            //Создаем и возвращаем новую, если такой не было
            var newSession = new Session() { LanguageCode = "ru" };
            _sessions.TryAdd(chatId, newSession);
            return newSession;
        }
    }
}
