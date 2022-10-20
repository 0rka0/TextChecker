namespace TextChecker
{
    using Caliburn.Micro;
    using System.Windows;
    using TextChecker.ViewModels;

    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
