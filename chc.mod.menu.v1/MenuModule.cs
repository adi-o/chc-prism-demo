namespace chc.mod.menu.v1
{
    using inf.logging;
    using Microsoft.Practices.Prism.Logging;
    using Microsoft.Practices.Prism.Modularity;
    using Microsoft.Practices.Prism.Regions;
    using Microsoft.Practices.ServiceLocation;
    using Microsoft.Practices.Unity;

    [Module(ModuleName = "MenuModule",OnDemand = false)]
    public class MenuModule:IModule
    {
        public void Initialize()
        {
            var container = ServiceLocator.Current.GetInstance<IUnityContainer>();
            var logger = container.Resolve<ILogger>();
            logger.Log("#### Hello from menuModule");

            var regionManager = container.Resolve<IRegionManager>();

            regionManager.RegisterViewWithRegion("menu", typeof(MenuView));
        }
    }

}
