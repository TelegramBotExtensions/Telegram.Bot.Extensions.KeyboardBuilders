using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Extensions.KeyboardBuilders
{
    public static class KeyboardBuilderExtensions
    {
        public static KeyboardRow<KeyboardButton> AddLocationButton(
            this KeyboardRow<KeyboardButton> rowBuilder, string text)
            => rowBuilder.AddButton(KeyboardButton.WithRequestLocation(text));

        public static KeyboardRow<KeyboardButton> AddContactButton(
            this KeyboardRow<KeyboardButton> rowBuilder, string text)
            => rowBuilder.AddButton(KeyboardButton.WithRequestContact(text));

        public static KeyboardRow<KeyboardButton> AddTextButton(
            this KeyboardRow<KeyboardButton> rowBuilder, string title)
            => rowBuilder.AddButton(title);

        public static KeyboardRow<InlineKeyboardButton> AddUrlButton(
            this KeyboardRow<InlineKeyboardButton> rowBuilder, string title, string url)
            => rowBuilder.AddButton(InlineKeyboardButton.WithUrl(title, url));

        public static KeyboardRow<InlineKeyboardButton> AddCallbackDataButton(
            this KeyboardRow<InlineKeyboardButton> rowBuilder, string title, string callbackData)
            => rowBuilder.AddButton(InlineKeyboardButton.WithCallbackData(title, callbackData));

        public static KeyboardRow<InlineKeyboardButton> AddCallbackDataButton(
            this KeyboardRow<InlineKeyboardButton> rowBuilder, string titleAndData)
            => rowBuilder.AddButton(InlineKeyboardButton.WithCallbackData(titleAndData));

        public static KeyboardRow<InlineKeyboardButton> AddSwitchInlineQueryButton(
            this KeyboardRow<InlineKeyboardButton> rowBuilder, string text, string query = "")
            => rowBuilder.AddButton(InlineKeyboardButton.WithSwitchInlineQuery(text, query));

        public static KeyboardRow<InlineKeyboardButton> AddSwitchInlineQueryCurrentChatButton(
            this KeyboardRow<InlineKeyboardButton> rowBuilder, string text, string query = "")
            => rowBuilder.AddButton(InlineKeyboardButton.WithSwitchInlineQueryCurrentChat(text, query));

        public static KeyboardRow<InlineKeyboardButton> AddPaymentButton(
            this KeyboardRow<InlineKeyboardButton> rowBuilder, string text)
            => rowBuilder.AddButton(InlineKeyboardButton.WithPayment(text));
    }
}
