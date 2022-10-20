namespace TextCheckerBL.TextHandler
{
    using System.Linq;

    public class CheckPalindromeHandler
    {
        public bool Check(string textInput)
        {
            return textInput.SequenceEqual(textInput.Reverse());
        }
    }
}
