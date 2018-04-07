# Keyboard builders

[![license](https://img.shields.io/github/license/Tuscen/Telegram.Bot.Extensions.KeyboardBuilders.svg)](https://github.com/Tuscen/Telegram.Bot.Extensions.KeyboardBuilders/blob/develop/LICENCE)

| Branch | Status |
|:------:|:-------|
| `master` | [![Build status](https://ci.appveyor.com/api/projects/status/6viiwy5alg7jk84f/branch/master?svg=true)](https://ci.appveyor.com/project/Tuscen/telegram-bot-extensions-keyboardbuilders/branch/master) |
| `develop` | [![Build status](https://ci.appveyor.com/api/projects/status/6viiwy5alg7jk84f/branch/develop?svg=true)](https://ci.appveyor.com/project/Tuscen/telegram-bot-extensions-keyboardbuilders/branch/develop) |

This library is supposed to be used with [Telegram.Bot](https://github.com/TelegramBots/Telegram.Bot).

### Usage

Reply keyboard markup:

```csharp
var keyboard = new RegularKeyboardBuilder();

keyboard.AddRow(row =>
    {
        row.AddButton(new KeyboardButton("Hello"))
            .AddTextButton("World");
    })
    .AddRow(row =>
    {
        row.AddContactButton("Send your contact")
            .AddLocationButton("Sens your location");
    });

// You can then either use implicit convertion to  appropriate reply markup type:

ReplyKeyboardMarkup implicitReplyMarkup = keyboard;

// Or pass it as a parameter to markup constructor:
var replyMarkup = new ReplyKeyboardMarkup(keyboard);
```

Inline keyboard markup:
```csharp
var inlineKeyboard = new InlineKeyboardBuilder();

inlineKeyboard.AddRow(row =>
    {
        row.AddPaymentButton("Pay");

        var button = InlineKeyboardButton
            .WithCallbackData("Button text", "callback data");

        row.AddButton(button);
            .AddCallbackDataButton("Do something", "{callback data}");
    })
    .AddRow(row =>
    {
        row.AddContactButton("Send your contact")
            .AddLocationButton("Sens your location");
    });


InlineKeyboardMarkup implicitReplyMarkup = inlineKeyboard;

var replyMarkup = new InlineKeyboardMarkup(inlineKeyboard);
```
