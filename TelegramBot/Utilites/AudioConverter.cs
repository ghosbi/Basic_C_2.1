using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFMpegCore;
using TelegramBot.Extensions;

namespace TelegramBot.Utilites
{
    public static class AudioConverter
    {
        public static void TryConverter(string inputFile, string outputFile)
        {
            //Задаем путь, где лежит вспомогательная программа - конвертер
            GlobalFFOptions.Configure(options => options.BinaryFolder = Path.Combine(DirecoryExtension.GetSolutionRoot(), "ffmpeg-win64", "bin"));

            //Вызываем Ffmpeg, передав требуемые аргументы.
            FFMpegArguments.FromFileInput(inputFile)
                .OutputToFile(outputFile, true, options => options.WithFastStart())
                .ProcessSynchronously();
        }

        private static string GetSolutionRoot()
        {
            var dir = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            var fullname = Directory.GetParent(dir).FullName;
            var projectRoot = fullname.Substring(0, fullname.Length - 4);
            return Directory.GetParent(projectRoot)?.FullName;
        }
    }
}
