namespace TextChecker.ViewModels
{
    using Caliburn.Micro;
    using System;
    using TextCheckerBL.TextHandler;

    public class ShellViewModel : Screen
    {
        private string textInput;

        public string TextInput
        {
            get 
            { 
                return textInput; 
            }
            set 
            { 
                textInput = value;
                NotifyOfPropertyChange(() => TextInput);
            }
        }

        private string resultOutput;

        public string ResultOutput
        {
            get 
            { 
                return resultOutput; 
            }
            set 
            {
                resultOutput = value;
                NotifyOfPropertyChange(() => ResultOutput);
            }
        }

        public bool CanCheckPalindrome(string textInput)
        {
            return !String.IsNullOrWhiteSpace(textInput);
        }

        public void CheckPalindrome(string textInput)
        {
            var handler = new CheckPalindromeHandler();
            bool isPalindrome = handler.Check(TextInput);

            if (isPalindrome)
            {
                ResultOutput = $"{TextInput} ist ein Palindrome.";
            }
            else
            {
                ResultOutput = $"{TextInput} ist kein Palindrome.";
            }

            TextInput = String.Empty;
        }
    }
}
