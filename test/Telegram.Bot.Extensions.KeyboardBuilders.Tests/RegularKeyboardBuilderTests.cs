using System;
using Telegram.Bot.Types.ReplyMarkups;
using Xunit;

namespace Telegram.Bot.Extensions.KeyboardBuilders.Tests
{
    public class RegularKeyboardBuilderTests
    {
        [Fact]
        public void Throws_Invalid_Operation_Exception_During_Enumeration_If_Modified()
        {
            RegularKeyboardBuilder keyboardBuilder = new RegularKeyboardBuilder();
            keyboardBuilder.AddRow(row => row.AddTextButton("foo"));

            Assert.Throws<InvalidOperationException>(() =>
            {
                foreach (var _ in keyboardBuilder)
                {
                    keyboardBuilder.AddRow(row => row.AddTextButton("bar"));
                }
            });
        }

        [Fact]
        public void Implicitly_Casts_To_Reply_Keyboard_Markup()
        {
            RegularKeyboardBuilder keyboardBuilder = new RegularKeyboardBuilder();
            keyboardBuilder.AddRow(row => row.AddTextButton("foo"));

            ReplyKeyboardMarkup replyKeyboardMarkup = keyboardBuilder;
            Assert.NotEmpty(replyKeyboardMarkup.Keyboard);
            Assert.All(replyKeyboardMarkup.Keyboard, Assert.NotEmpty);
        }

        [Fact]
        public void Can_Be_Passed_As_Parameter_To_Reply_Keyboard_Markup()
        {
            RegularKeyboardBuilder keyboardBuilder = new RegularKeyboardBuilder();
            keyboardBuilder.AddRow(row => row.AddTextButton("foo"));

            ReplyKeyboardMarkup replyKeyboardMarkup = new ReplyKeyboardMarkup(keyboardBuilder);
            Assert.NotEmpty(replyKeyboardMarkup.Keyboard);
            Assert.All(replyKeyboardMarkup.Keyboard, Assert.NotEmpty);
        }
    }
}
