namespace App.DesktopClient
{
    using Microsoft.Practices.Unity;
    using System.Windows;
    using Prism.Unity;

    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
