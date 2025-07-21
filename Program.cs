
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
namespace MyTelegramBot
{
    class Program
    {
        private static string token = "7813569276:AAFWGwkJUrtUBO83W6GnIAnHY_1dEXQc3gs";
        private static TelegramBotClient botClient = null!;
        static async Task Main()
        {
            botClient = new TelegramBotClient(token);
            var me = await botClient.GetMeAsync();
            Console.WriteLine($"Бот {me.Username} запущен!");
            botClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync
            );
            await Task.Delay(-1); // Бесконечное ожидание
        }
        static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, System.Threading.CancellationToken cancellationToken)
        {
            if (update.Type != UpdateType.Message || update.Message?.Text == null)
                return;
            var chatId = update.Message.Chat.Id;
            var messageText = update.Message.Text;
            if (messageText == "/start" || messageText == "⬅️ Назад")
            {
                var mainKeyboard = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] { "Стикеры / Stickers" },
                    new KeyboardButton[] { "Биография / Biography" },
                    new KeyboardButton[] { "Обои / Wallpapers" }
                })
                {
                    ResizeKeyboard = true
                };
                await botClient.SendTextMessageAsync(chatId,
                    "Здравствуйте!! рада видеть вас на своем канале, посвящённом стикерам по игре Wuthering Waves. Навигация:",
                    replyMarkup: mainKeyboard,
                    cancellationToken: cancellationToken);
                return;
            }
            if (messageText == "Стикеры / Stickers")
            {
                var characterKeyboard = GetCharacterKeyboard();
                await botClient.SendTextMessageAsync(chatId,
                    "Выберите персонажа, чтобы получить стикеры:",
                    replyMarkup: characterKeyboard,
                    cancellationToken: cancellationToken);
                return;
            }
            if (messageText == "Биография / Biography")
            {
                await botClient.SendTextMessageAsync(chatId,
                    "Здесь биография! (можно вставить текст)",
                    cancellationToken: cancellationToken);
                return;
            }
            if (messageText == "Обои / Wallpapers")
            {
                await botClient.SendTextMessageAsync(chatId,
                    "Здесь обои! (можно отправить изображения)",
                    cancellationToken: cancellationToken);
                return;
            }
            if (stickerData.ContainsKey(messageText))
            {
                var data = stickerData[messageText];
                var inlineKeyboard = new InlineKeyboardMarkup(data.StickerLinks.ConvertAll(
                    url => new[] { InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", url) }
                ));
                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(data.PreviewImage),
                    caption: $"Стикеры {messageText}\n{(data.StickerLinks.Count > 1 ? "Несколько наборов:" : "Один набор:")}",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);
                return;
            }
            await botClient.SendTextMessageAsync(chatId,
                "Запрос некорректен. Нажмите /start чтобы увидеть кнопки.",
                cancellationToken: cancellationToken);
        }
        static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, System.Threading.CancellationToken cancellationToken)
        {
            Console.WriteLine($"Ошибка: {exception.Message}");
            return Task.CompletedTask;
        }
        static ReplyKeyboardMarkup GetCharacterKeyboard()
        {
            return new ReplyKeyboardMarkup(new[]
            {
                new KeyboardButton[] { "Aalto 🌬", "Baizhi 🧊", "Brant ⚓️" },
                new KeyboardButton[] { "Cantarella 💓", "Calcharo ⚡️", "Camellya 💮" },
                new KeyboardButton[] { "Carlotta 🔫", "Cartethyia 👑", "Ciaccona ❤️" },
                new KeyboardButton[] { "Changli 🔥", "Chixia 🍁", "Danjin 🟥" },
                new KeyboardButton[] { "Encore 🚼", "GeshuLin", "Jianxin 🍃" },
                new KeyboardButton[] { "Jinshi 🐉", "Jiyan 🟩", "Lingyang 🦁" },
                new KeyboardButton[] { "Lupa 🐺", "Lumi 🐭", "Luno 💦" },
                new KeyboardButton[] { "Mortefi 📛", "Phoebe 🪞", "Phrolova 💮" },
                new KeyboardButton[] { "Roccia 💼", "Rover 🤵‍♂️", "Sanhua ❤️" },
                new KeyboardButton[] { "Scar", "TheShorekeeper 🦋", "Taoqi 🍒" },
                new KeyboardButton[] { "Verina 🏵", "XiangliYao 🏎", "YangYang 🐦‍⬛️" },
                new KeyboardButton[] { "Yinlin ♥️", "Youhu 🎰", "Zani 🖤", "Zhezhi 🖌" },
                new KeyboardButton[] { "⬅️ Назад" }
            })
            {
                ResizeKeyboard = true
            };
        }
        class StickerInfo
        {
            // Теперь инициализируем сразу, чтобы не было предупреждений
            public string PreviewImage { get; set; } = string.Empty;
            public List<string> StickerLinks { get; set; } = new List<string>();
        }
        static Dictionary<string, StickerInfo> stickerData = new Dictionary<string, StickerInfo>
        {
            {
                "Aalto 🌬", new StickerInfo
                {
                    PreviewImage = "https://www.prydwen.gg/static/28692b3a188f6b7b14a9d28aa90bf3c8/b26e2/aalto_card.webp",
                    StickerLinks = new List<string>
                    {
                        "https://t.me/addstickers/Aalto_ba72d_by_TgEmodziBot",
                        "https://t.me/addstickers/pack_Aalto_by_TgEmodziBot"
                    }
                }
            },
            {
                "Baizhi 🧊", new StickerInfo
                {
                    PreviewImage = "https://i.pinimg.com/originals/02/81/b0/0281b042df94d62409d6b87aa97b6892.jpg",
                    StickerLinks = new List<string>
                    {
                        "https://t.me/addstickers/Baizhi_by_TgEmodziBot",
                        "https://t.me/addstickers/pack_Baizhi_by_TgEmodziBot"
                    }
                }
            },
            {
                "Brant ⚓️", new StickerInfo
                {
                    PreviewImage = "https://tse1.mm.bing.net/th/id/OIP.f-Xj6XRiZDtAlKisIIM5AQHaKN",
                    StickerLinks = new List<string>
                    {
                        "https://t.me/addstickers/brantsts_by_fStikBot",
                        "https://t.me/addstickers/Brant_da314_by_TgEmodziBot"
                    }
                }
            }
            // 🔁 Добавьте остальные персонажи по аналогии
        };
    }
}
