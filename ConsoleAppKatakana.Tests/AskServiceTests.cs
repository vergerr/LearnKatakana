using Moq;
using ConsoleAppKatakana;
using ConsoleAppKatakana.Interface;
using ConsoleAppKatakana.Domain;
using TestProject;

namespace ConsoleAppKatakana.Tests
{
    public class AskServiceTests
    {
        [Fact]
        public void Study_WritesOutput()
        {
            var fakeCOnsole = new FakeConsole();

            var sut = new AskService(fakeCOnsole);

            sut.Study(AlphabetSample.SampleAlphabet);

            Assert.Contains("Study", fakeCOnsole.Outputs);
        }
    }
}
