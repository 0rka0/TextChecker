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
        public void Check_ReceivesPalindrome_ReturnsTrue()
        {
            string input = "Abcddcba";
            bool result = handler.Check(input);

            Assert.True(result);
        }

        [Fact]
        public void Check_ReceivesInvalidPalindrome_ReturnsFalse()
        {
            string input = "Abcdefghij";
            bool result = handler.Check(input);

            Assert.False(result);
        }
    }
}
