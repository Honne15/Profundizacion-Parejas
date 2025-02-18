using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace PruebaTDD.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(15, "SunMoon")]
        [InlineData(9, "Sun")]
        [InlineData(10, "Moon")]
        [InlineData(7, "No es múltiplo de 3 ni de 5")]
        public void GetNumber(int number, string word)
        {
            var result = Program.NumberVerify(number);
            Assert.Equal(result, word);
        }
    }
}
