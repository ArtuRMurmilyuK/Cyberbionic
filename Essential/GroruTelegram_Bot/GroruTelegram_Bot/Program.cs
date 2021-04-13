using System;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace GroruTelegram_Bot
{
    class Program
    {
        private static string Token { get; set; } = "1624616499:AAEA-46OkTrKq-p8ny8nj6vSetiPR3Mk3-c";
        private static TelegramBotClient _client;
        static void Main(string[] args)
        {
            _client = new TelegramBotClient(Token);
            _client.StartReceiving();
            _client.OnMessage += OnMessageHandler;
            Console.ReadKey();
            _client.StopReceiving();
        }

        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text != null)
            {
                switch (msg.Text)
                {
                    case "Hi":
                        var stic = await _client.SendStickerAsync(
                        chatId: msg.Chat.Id,
                        sticker: "https://tlgrm.ru/_/stickers/c04/fe1/c04fe137-edbc-41e7-a199-b530c42bfe9e/192/14.webp", replyMarkup: GetButton());
                        break;
                    case "How are you?":
                        await _client.SendTextMessageAsync(msg.Chat.Id, "Всё хорошо, спасибо🌝", replyMarkup: GetButton());
                        break;
                    case "By":
                        await _client.SendTextMessageAsync(msg.Chat.Id, "Пока, хорошего дня", replyMarkup: GetButton());
                        stic = await _client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker:
                            "https://tlgrm.ru/_/stickers/c04/fe1/c04fe137-edbc-41e7-a199-b530c42bfe9e/192/15.webp",
                            replyMarkup: GetButton());
                        break;
                    default:
                        await _client.SendTextMessageAsync(msg.Chat.Id, "Выбери команду", replyMarkup: GetButton());
                        break;
                }
            }
        }

        private static IReplyMarkup GetButton()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<IEnumerable<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton{Text = "Hi"}, new KeyboardButton{Text = "By"}},
                    new List<KeyboardButton>{new KeyboardButton{Text = "How are you?"}, new KeyboardButton{Text = "test"}}
                }
            };
        }
    }
}
