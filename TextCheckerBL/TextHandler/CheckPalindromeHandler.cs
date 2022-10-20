namespace TextCheckerBL.TextHandler
{
    using System.Linq;

    public class CheckPalindromeHandler
    {
        public bool Check(string textInput)
        {
            return textInput.ToLower().SequenceEqual(textInput.ToLower().Reverse());
        }
    }
}
