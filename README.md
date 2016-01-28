# globalization_sitemapprovider
Demo showing how to implement globalization with siteMapProvider

###Change the web.config -> appSettings
+ `<add key="MvcSiteMapProvider_IncludeAssembliesForScan" value="YourProjectName" />`
+ `<add key="MvcSiteMapProvider_UseExternalDIContainer" value="true" />`
+ `<add key="MvcSiteMapProvider_ScanAssembliesForSiteMapNodes" value="true" />`

###Add the following files:
+ ResourceManagerStringLocalizer.cs
+ All files in folder DI

###In App_Start:
+ CompositionRoot.cs
+ DIConfig.cs
+ MvcSiteMapProviderConfig.cs
+ CultureFilter.cs

###Change routeConfig:
+ url: "{lang}/{controller}/{action}/{id}",
+ constraints: new { lang = @"(\w{2})|(\w{2}-\w{2})" },
+ defaults: new { lang = "en", controller = "Home", action = "Index", id = UrlParameter.Optional }

###Change title in Mvc.SiteMap:
+ title="$resources:Language.Resources.SiteMap.Resources,Home"
+ Language.Resources.SiteMap.Resources = route to your resource
+ Home = name in your resource

###Add the reference:
+ System.Runtime.Caching
