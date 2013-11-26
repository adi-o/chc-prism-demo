namespace chc.mod.inf.logging.mock
{
    using Microsoft.Practices.Prism.Modularity;
    using Microsoft.Practices.ServiceLocation;
    using Microsoft.Practices.Unity;

    [Module(ModuleName = "LoggingModule",OnDemand = false)]
    public class LoggingModule:IModule
    {
        public void Initialize()
        {
            var container = ServiceLocator.Current.GetInstance<IUnityContainer>();
            container.RegisterType<ILogger,DebugLogger>();
        }
    }

}
