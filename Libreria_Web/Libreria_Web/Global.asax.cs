//using Libreria_Web.Contract;
//using Libreria_Web.Services;
//using SimpleInjector;
//using SimpleInjector.Integration.Web;
//using SimpleInjector.Integration.Web.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Optimization;
//using System.Web.Routing;

//namespace Libreria_Web
//{
//    public class MvcApplication : System.Web.HttpApplication
//    {
//        protected void Application_Start()
//        {
//            AreaRegistration.RegisterAllAreas();
//            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
//            RouteConfig.RegisterRoutes(RouteTable.Routes);
//            BundleConfig.RegisterBundles(BundleTable.Bundles);

//            var container = new Container();
//            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

//            container.Register<IService, Service>(Lifestyle.Scoped);

//            container.RegisterMvcControllers(System.Reflection.Assembly.GetExecutingAssembly());
//            container.RegisterMvcIntegratedFilterProvider();
//            container.Verify();
//            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Libreria_Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
