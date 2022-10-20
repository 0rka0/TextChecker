namespace TextCheckerBL.TextHandler
{
    using System;
    using System.Linq;

    public class CheckPalindromeHandler
    {
        public bool Check(string textInput)
        {
            string text = String.Concat(textInput.Where(c => !Char.IsWhiteSpace(c))).ToLower();
            int length = text.Length;

            for (int i = 0; i < length / 2; i++)
            {
                int j = length - i - 1;
                if (text[i] != text[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
