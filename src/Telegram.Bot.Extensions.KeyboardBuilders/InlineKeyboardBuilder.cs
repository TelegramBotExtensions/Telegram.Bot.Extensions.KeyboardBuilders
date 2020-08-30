using System;
using System.Collections;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Extensions.KeyboardBuilders
{
    public class InlineKeyboardBuilder : IEnumerable<KeyboardRow<InlineKeyboardButton>>
    {
        private readonly IList<KeyboardRow<InlineKeyboardButton>> _rows = new List<KeyboardRow<InlineKeyboardButton>>();

        public InlineKeyboardBuilder AddRow(Action<KeyboardRow<InlineKeyboardButton>> rowBuilder)
        {
            var newRow = new KeyboardRow<InlineKeyboardButton>();
            rowBuilder(newRow);
            _rows.Add(newRow);
            return this;
        }

        public IEnumerator<KeyboardRow<InlineKeyboardButton>> GetEnumerator() => _rows.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public static implicit operator InlineKeyboardMarkup(InlineKeyboardBuilder keyboardBuilder)
            => new InlineKeyboardMarkup(keyboardBuilder);
    }
}
