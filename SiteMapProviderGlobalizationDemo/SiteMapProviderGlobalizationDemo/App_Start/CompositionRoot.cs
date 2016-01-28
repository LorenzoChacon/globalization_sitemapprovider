using StructureMap;
using SiteMapProviderGlobalizationDemo.DI;
using SiteMapProviderGlobalizationDemo.DI.StructureMap;
using SiteMapProviderGlobalizationDemo.DI.StructureMap.Registries;

internal class CompositionRoot
{
    public static IDependencyInjectionContainer Compose()
    {
// Create the DI container
        var container = new Container();

// Setup configuration of DI
        container.Configure(r => r.AddRegistry<MvcSiteMapProviderRegistry>());

#if DEBUG
        container.AssertConfigurationIsValid();
#endif

// Return our DI container wrapper instance
        return new StructureMapDependencyInjectionContainer(container);
    }
}
