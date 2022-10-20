namespace TextChecker.ViewModels
{
    using Caliburn.Micro;
    using System;
    using TextCheckerBL.TextHandler;

    public class ShellViewModel : Screen
    {
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

        private string textInput;

        private string resultOutput;

        public bool CanCheckPalindrome(string textInput)
        {
            return !String.IsNullOrWhiteSpace(textInput);
        }

        public void CheckPalindrome(string textInput)
        {
            var handler = new CheckPalindromeHandler();
            bool isPalindrome = handler.Check(textInput);

            if (isPalindrome)
            {
                ResultOutput = $"\"{textInput}\" ist ein Palindrome.";
            }
            else
            {
                ResultOutput = $"\"{textInput}\" ist kein Palindrome.";
            }

            TextInput = String.Empty;
        }
    }
}
