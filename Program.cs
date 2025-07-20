using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

class Program
{
    private static string token = "7813569276:AAFWGwkJUrtUBO83W6GnIAnHY_1dEXQc3gs";
    private static TelegramBotClient botClient = new TelegramBotClient(token);
    static async Task Main()
    {
        botClient = new TelegramBotClient(token);

        var me = await botClient.GetMeAsync();
        Console.WriteLine($"Бот {me.Username} запущен!");

        botClient.StartReceiving(
            HandleUpdateAsync,
            HandleErrorAsync
        );

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
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
                "Здравствуйте!! рада видеть вас на своем канале посвещенный стикерам по игре Wuthering Waves. Навигация:",
                replyMarkup: mainKeyboard,
                cancellationToken: cancellationToken);
            return;
        }

        switch (messageText)
        {
            case "Стикеры / Stickers":
                var characterKeyboard = new ReplyKeyboardMarkup(new[]
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

                await botClient.SendTextMessageAsync(chatId,
                    "Выберите персонажа, чтобы получить стикеры:",
                    replyMarkup: characterKeyboard,
                    cancellationToken: cancellationToken);
                break;

             case "Aalto 🌬":
                {
                string previewImageUrl = "https://www.prydwen.gg/static/28692b3a188f6b7b14a9d28aa90bf3c8/b26e2/aalto_card.webp"; 
                string stickerUrl1 = "https://t.me/addstickers/Aalto_ba72d_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/pack_Aalto_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Aalto 🌬\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
               case "Baizhi 🧊":
                {
                string previewImageUrl = "https://i.pinimg.com/originals/02/81/b0/0281b042df94d62409d6b87aa97b6892.jpg"; 
                string stickerUrl1 = "https://t.me/addstickers/Baizhi_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/pack_Baizhi_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Baizhi 🧊\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
                case "Brant ⚓️":
                {
                string previewImageUrl = "https://tse1.mm.bing.net/th/id/OIP.f-Xj6XRiZDtAlKisIIM5AQHaKN?r=0&rs=1&pid=ImgDetMain&o=7&rm=3"; 
                string stickerUrl1 = "https://t.me/addstickers/brantsts_by_fStikBot"; 
                string stickerUrl2 = "https://t.me/addstickers/Brant_da314_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Brant ⚓️\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
               case "Cantarella 💓":
                {
                string previewImageUrl = "https://tse1.mm.bing.net/th/id/OIP.afwFhFEaMWh82mv-ELKIoAHaLd?r=0&rs=1&pid=ImgDetMain&o=7&rm=3"; 
                string stickerUrl1 = "https://t.me/addstickers/sticks_Cantarella_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/Cantarella_830d2_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Cantarella 💓\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
             case "Calcharo ⚡️":
                {
                string previewImageUrl = "https://tse2.mm.bing.net/th/id/OIP.lB5RatwAxO1SL6qTY8_PfAAAAA?r=0&rs=1&pid=ImgDetMain&o=7&rm=3"; 
                string stickerUrl1 = "https://t.me/addstickers/Calcharo_6eabd_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/Calcharo_de06f_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Calcharo ⚡️\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
               case "Camellya 💮":
                {
                string previewImageUrl = "https://i.ytimg.com/vi/gcOIPdhxV3Q/oardefault.jpg?sqp=-oaymwEYCIkEENAFSFqQAgHyq4qpAwcIARUAAIhC&rs=AOn4CLAAxISwIJVqjg-zmCU3tEDBbKlqXQ"; 
                string stickerUrl1 = "https://t.me/addstickers/Camellya_fff65_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/Camellya_623bb_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Camellya 💮\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
                 case "Carlotta 🔫":
                {
                string previewImageUrl = "https://i.pinimg.com/736x/bb/4e/b3/bb4eb3fd632e0cfa9450803f40619123.jpg"; 
                string stickerUrl1 = "https://t.me/addstickers/sti_Carlotta_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/Changli_Carlotta_by_TgEmodziBotгн"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Carlotta 🔫\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
                     case "Cartethyia 👑":
                {
                string previewImageUrl = "https://tse3.mm.bing.net/th/id/OIP.cD63UF0aT26PHoBH8OohRAHaKf?r=0&rs=1&pid=ImgDetMain&o=7&rm=3"; 
                string stickerUrl1 = "https://t.me/addstickers/Cartethyia_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/sti_Cartethyia_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Cartethyia 👑\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
                  case "Ciaccona ❤️":
                {
                string previewImageUrl = "https://cdn.wuwatracker.com/static/assets/resonator/role/ciaccona.webp"; 
                string stickerUrl1 = "https://t.me/addstickers/sticks_Ciaccona_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/sti_Ciaccona_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Ciaccona ❤️\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
                case "Changli 🔥":
                {
                    string previewImageUrl = "https://i.pinimg.com/736x/7c/d9/e4/7cd9e4aeca1045c2cac5062fb1dad6dc.jpg";
                    string stickerUrl1 = "https://t.me/addstickers/Changligy_by_fStikBot";
                    string stickerUrl2 = "https://t.me/addstickers/sticks_Changli_by_TgEmodziBot";

                    var inlineKeyboard = new InlineKeyboardMarkup(new[]
                    {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                    await botClient.SendPhotoAsync(
                        chatId: chatId,
                        photo: InputFile.FromUri(previewImageUrl),
                        caption: "Стикеры Changli 🔥\nДва разных набора:",
                        replyMarkup: inlineKeyboard,
                        cancellationToken: cancellationToken);

                    break;
                    }
                     case "Chixia 🍁":
                {
                string previewImageUrl = "https://static.dotgg.gg/wuthering-waves/characters/chixia-image.webp"; 
                string stickerUrl1 = "https://t.me/addstickers/Chixia_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/pack_Chixia_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Chixia 🍁\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
                case "Danjin 🟥":
                {
                string previewImageUrl = "https://i.pinimg.com/736x/2d/17/da/2d17da12af20c3c33d7312cffbf1bc02.jpg"; 
                string stickerUrl1 = "https://t.me/addstickers/Danjin_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Danjin 🟥\nОдин набор:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
                 case "Encore 🚼":
                {
                string previewImageUrl = "https://i.pinimg.com/736x/a2/dc/88/a2dc88925ceb31e59b33e76c6e0dca5b.jpg"; 
                string stickerUrl1 = "https://t.me/addstickers/sti_Encore_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/sticks_Encore_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Encore 🚼\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
                case "GeshuLin":
                {
                string previewImageUrl = "https://i.pinimg.com/736x/95/03/ee/9503ee8b4de01710c75b689365c54926.jpg"; 
                string stickerUrl1 = "https://t.me/addstickers/Geshu_lin_e854c_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры GeshuLin\nОдин набор:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
                 case "Jinshi 🐉":
                {
                string previewImageUrl = "https://i.pinimg.com/736x/1b/de/78/1bde7826fb4b60194ed53654de8dde4f.jpg"; 
                string stickerUrl1 = "https://t.me/addstickers/WutheringWavesSticker_by_fStikBot"; 
                string stickerUrl2 = "https://t.me/addstickers/Dragon_Jinhsi_more_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Jinshi 🐉\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
                case "Jianxin 🍃":
                {
                string previewImageUrl = "https://tse3.mm.bing.net/th/id/OIP.BlPCXwD07d1nx6JD3Or7nAAAAA?r=0&rs=1&pid=ImgDetMain&o=7&rm=3"; 
                string stickerUrl1 = "https://t.me/addstickers/sti_Jianxin_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Стикеры Jianxin 🍃\nОдин набор:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
             case "Jiyan 🟩":
                {
                string previewImageUrl = "https://i.pinimg.com/736x/f7/78/89/f778891f0aa475f2abfdcb5df776e4df.jpg"; 
                string stickerUrl1 = "https://t.me/addstickers/stik_Jiyan_by_TgEmodziBot"; 
                string stickerUrl2 = "https://t.me/addstickers/Jiyan_8bec0_by_TgEmodziBot"; 

                var inlineKeyboard = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl1)
                    },
                    new[]
                    {
                        InlineKeyboardButton.WithUrl("🖼 Открыть стикерпак", stickerUrl2)
                    }
                });

                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: InputFile.FromUri(previewImageUrl),
                    caption: "Jiyan 🟩\nДва разных набора:",
                    replyMarkup: inlineKeyboard,
                    cancellationToken: cancellationToken);

                break;
            }
             case "Биография / Biography":
                await botClient.SendTextMessageAsync(chatId, "Здесь биография! (можно вставить текст)");
                break;

            case "Обои / Wallpapers":
                await botClient.SendTextMessageAsync(chatId, "Здесь обои! (можно отправить изображения)");
                break;

            default:
                await botClient.SendTextMessageAsync(chatId, "Запрос некорректен. Нажмите /start чтобы увидеть кнопки.");
                break;
        }
    }

    static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, System.Threading.CancellationToken cancellationToken)
    {
        Console.WriteLine($"Ошибка: {exception.Message}");
        return Task.CompletedTask;
    }
}