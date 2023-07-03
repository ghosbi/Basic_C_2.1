using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot.Services
{
    public interface IFileHandler
    {
        Task Downolad(string fileId, CancellationToken ct);
        string Process(string param);
    }
}
