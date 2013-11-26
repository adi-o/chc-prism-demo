using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace chc.portal
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        Bootstrapper bootstrapper;
        protected override void OnStartup(StartupEventArgs e)
        {
            bootstrapper = new Bootstrapper();
            bootstrapper.Run();
            base.OnStartup(e);
        }
    }
}
