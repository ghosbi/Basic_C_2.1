using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBot.Models;

namespace TelegramBot.Services
{
    public interface IStorage
    {
        ///<summary>
        ///Получение сессии пользователя под идентификатору
        /// </summary>
        Session GetSession(long chatId);
    }
}
