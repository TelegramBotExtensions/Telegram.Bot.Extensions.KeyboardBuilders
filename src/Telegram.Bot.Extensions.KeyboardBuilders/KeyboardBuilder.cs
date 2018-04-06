using System;
using System.Collections;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Extensions.KeyboardBuilders
{
    public abstract class KeyboardBuilder<TButton> : IEnumerable<KeyboardRow<TButton>>
        where TButton : IKeyboardButton
    {
        private readonly IList<KeyboardRow<TButton>> _rows = new List<KeyboardRow<TButton>>();

        public KeyboardBuilder<TButton> AddRow(Action<KeyboardRow<TButton>> rowBuilder)
        {
            var newRow = new KeyboardRow<TButton>();
            rowBuilder(newRow);
            _rows.Add(newRow);
            return this;
        }

        public IEnumerator<KeyboardRow<TButton>> GetEnumerator()
        {
            return _rows.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
