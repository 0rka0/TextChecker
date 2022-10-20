namespace TextCheckerTests
{
    using TextCheckerBL.TextHandler;
    using Xunit;

    public class CheckPalindromeHandlerTests
    {
        private CheckPalindromeHandler handler;

        public CheckPalindromeHandlerTests()
        {
            handler = new CheckPalindromeHandler();
        }

        [Fact]
        public void Check_ReceivesPalindromeEvenNumberOfChars_ReturnsTrue()
        {
            string input = "Abcddcba";
            bool result = handler.Check(input);

            Assert.True(result);
        }

        [Fact]
        public void Check_ReceivesPalindromeOddNumberOfChars_ReturnsTrue()
        {
            string input = "Abcdedcba";
            bool result = handler.Check(input);

            Assert.True(result);
        }

        [Fact]
        public void Check_ReceivesInvalidPalindromeEvenNumberOfChars_ReturnsFalse()
        {
            string input = "Abcdefghij";
            bool result = handler.Check(input);

            Assert.False(result);
        }

        [Fact]
        public void Check_ReceivesInvalidPalindromeOddNumberOfChars_ReturnsFalse()
        {
            string input = "Abcdefghi";
            bool result = handler.Check(input);

            Assert.False(result);
        }

        [Fact]
        public void Check_ReceivesPalindromeWithWhitespaces_ReturnsTrue()
        {
            string input = "Abc d c ba";
            bool result = handler.Check(input);

            Assert.True(result);
        }
    }
}
