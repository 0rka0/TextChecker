namespace TextChecker.Viewmodels
{
    using System.Windows.Input;
    using TextChecker.Commands;

    class MainViewModel : ViewModelBase
    {
        public string TextInput
        {
            get
            {
                return textInput;
            }
            set
            {
                if (TextInput != value)
                {
                    textInput = value;
                    OnPropertyChanged(nameof(TextInput));
                }
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
                if (TextInput != value)
                {
                    resultOutput = value;
                    OnPropertyChanged(nameof(TextInput));
                }
            }
        }

        public ICommand ExecuteCheckPalindrome { get; }

        public MainViewModel()
        {
            this.ExecuteCheckPalindrome = new ExecuteCheckPalindrome(this);
        }

        private string textInput;

        private string resultOutput;
    }
}
