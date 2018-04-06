using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Extensions.KeyboardBuilders
{
    public class RegularKeyboardBuilder : KeyboardBuilder<KeyboardButton>
    {
        public static implicit operator ReplyKeyboardMarkup(RegularKeyboardBuilder keyboardBuilder)
            => new ReplyKeyboardMarkup(keyboardBuilder);
    }
}
