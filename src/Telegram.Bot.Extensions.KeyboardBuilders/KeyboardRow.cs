using System.Collections;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Extensions.KeyboardBuilders
{
    public class KeyboardRow<TButton> : IEnumerable<TButton>
        where TButton : IKeyboardButton
    {
        private readonly IList<TButton> _row = new List<TButton>();

        public KeyboardRow<TButton> AddButton(TButton button)
        {
            _row.Add(button);
            return this;
        }

        public IEnumerator<TButton> GetEnumerator() => _row.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
