using System;
using System.Collections;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Extensions.KeyboardBuilders
{
    public class RegularKeyboardBuilder : IEnumerable<KeyboardRow<KeyboardButton>>
    {
        private readonly IList<KeyboardRow<KeyboardButton>> _rows = new List<KeyboardRow<KeyboardButton>>();

        public RegularKeyboardBuilder AddRow(Action<KeyboardRow<KeyboardButton>> rowBuilder)
        {
            var newRow = new KeyboardRow<KeyboardButton>();
            rowBuilder(newRow);
            _rows.Add(newRow);
            return this;
        }

        public IEnumerator<KeyboardRow<KeyboardButton>> GetEnumerator() => _rows.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public static implicit operator ReplyKeyboardMarkup(RegularKeyboardBuilder keyboardBuilder)
            => new ReplyKeyboardMarkup(keyboardBuilder);
    }
}
