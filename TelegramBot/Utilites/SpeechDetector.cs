using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TelegramBot.Extensions;
using VoiceTexterBot.Extensions;
using Vosk;

namespace TelegramBot.Utilites
{
    public static class SpeechDetector
    {
        public static string DetectSpeech(string audioPath, float inputBitrate, string languageCode)
        {
            Vosk.Vosk.SetLogLevel(0);
            var modelPath = Path.Combine(DirecoryExtension.GetSolutionRoot(), "Speech-models", $"vosk-model-small-{languageCode.ToLower()}");
            Model model = new(modelPath);
            return GetWords(model, audioPath, inputBitrate);

        }

        ///<summary>
        ///Основной метод распознования слов
        /// </summary>
        private static string GetWords(Model model, string audioPath, float inputBitrate)
        {
            // В конструктор для распознавания передаем битрейт, а также используюему языковую модель
            VoskRecognizer rec = new(model, inputBitrate);
            rec.SetMaxAlternatives(0);
            rec.SetWords(true);

            StringBuilder textBuffer = new();

            using (Stream source = File.OpenRead(audioPath))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                {
                    //Распознавание отдельных слов
                    if (rec.AcceptWaveform(buffer, bytesRead))
                    {
                        var senteceJson = rec.Result();
                        //Сохраняем текстовый ввод в JSON-объект и извлекаем данные
                        JObject senteceObj = JObject.Parse(senteceJson);
                        string sentence = (string)senteceObj["text"];
                        textBuffer.Append(StringExtension.UppercaseFirst(sentence) + ". ");
                    }
                }
            }

            //Распознание предложений
            var finaleSentece = rec.FinalResult();
            //Сохраняем текстовый ввод в JSON - объект и извлекаем данные
            JObject finalSenteceObj = JObject.Parse(finaleSentece);

            //Собираем итоговый текст
            textBuffer.Append((string)finalSenteceObj["text"]);
            //Возвращаем в виде строки
            return textBuffer.ToString();
        }
    }
}
