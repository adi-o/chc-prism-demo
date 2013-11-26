using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace chc.portal
{
    using System.Windows;
    using Microsoft.Practices.Prism.Modularity;
    using Microsoft.Practices.Prism.UnityExtensions;

    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }
    }
}
