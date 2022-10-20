namespace TextChecker.Commands
{
    using System;
    using System.Windows.Input;
    using TextChecker.Viewmodels;

    class ExecuteCheckPalindrome : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public ExecuteCheckPalindrome(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
            this.viewModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "TextInput")
                {
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public bool CanExecute(object? parameter)
        {
            return !string.IsNullOrWhiteSpace(viewModel.TextInput);
        }

        public void Execute(object? parameter)
        {
            bool result = true; //Check for palindrome in BL

            if (result)
            {
                viewModel.ResultOutput = $"{viewModel.TextInput} ist ein Palindrom.";
            }
            else
            {
                viewModel.ResultOutput = $"{viewModel.TextInput} ist kein Palindrom.";
            }

            viewModel.TextInput = string.Empty;
        }

        private readonly MainViewModel viewModel;
    }
}
