using Moq;
using ConsoleAppKatakana;
using ConsoleAppKatakana.Interface;
using ConsoleAppKatakana.Domain;

namespace TestProject
{
    public class ValidCommandUserTests
    {
        [Fact]
        public void CommandAlphabet_H_IsValid()
        {
            var ask = new Mock<IAsk>().Object;
            var cu = new CommandUser();
            var sut = new ValidCommandUser(ask, cu);

            cu.CommandAlphabet = "H";

            Assert.True(sut.IsCommandAlphabetCorrect);
            Assert.Equal("Hiragana", sut.NameAlphabet);

        }

        [Fact]
        public void CommandAlphabet_X_NotValid()
        {
            var ask = new Mock<IAsk>().Object;
            var cu = new CommandUser();
            var sut = new ValidCommandUser(ask, cu);

            cu.CommandAlphabet = "X";

            Assert.False(sut.IsCommandAlphabetCorrect);
        }
    }
}
