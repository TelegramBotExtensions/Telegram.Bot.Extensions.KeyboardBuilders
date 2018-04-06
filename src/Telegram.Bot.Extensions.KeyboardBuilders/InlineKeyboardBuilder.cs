using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Extensions.KeyboardBuilders
{
    public class InlineKeyboardBuilder : KeyboardBuilder<InlineKeyboardButton>
    {
        public static implicit operator InlineKeyboardMarkup(InlineKeyboardBuilder keyboardBuilder)
            => new InlineKeyboardMarkup(keyboardBuilder);
    }
}
