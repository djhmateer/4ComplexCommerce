using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CommerceWebMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var controllerFactory = new CommerceControllerFactory();

            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        #region Castle Windsor, based on web.config
        /* Uncomment this section and comment out the current Application_Start to use this
         * configuration */
        //protected void Application_Start()
        //{
        //    MvcApplication.RegisterRoutes(RouteTable.Routes);

        //    var container =
        //        new WindsorContainer(new XmlInterpreter());
        //    var controllerFactory =
        //        container.Resolve<IControllerFactory>();

        //    ControllerBuilder.Current.SetControllerFactory(
        //        controllerFactory);
        //}
        #endregion

        #region Castle Windsor, convention-based
        /* Uncomment this section and comment out the current Application_Start to use this
         * configuration */
        //protected void Application_Start()
        //{
        //    MvcApplication.RegisterRoutes(RouteTable.Routes);

        //    var container = new WindsorContainer();
        //    container.Install(new CommerceWindsorInstaller());

        //    var controllerFactory =
        //        new WindsorControllerFactory(container);

        //    ControllerBuilder.Current.SetControllerFactory(
        //        controllerFactory);
        //}
        #endregion

        #region StructureMap, Code as Configuration
        /* Uncomment this section and comment out the current Application_Start to use this
         * configuration */
        //protected void Application_Start()
        //{
        //    MvcApplication.RegisterRoutes(RouteTable.Routes);

        //    var container = new Container();
        //    Ploeh.Samples.Commerce.Web.StructureMap.CommerceCodeAsConfiguration.Configure(container);

        //    var controllerFactory =
        //        new Ploeh.Samples.Commerce.Web.StructureMap.StructureMapControllerFactory(container);

        //    ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        //}
        #endregion

        #region StructureMap, convention-based
        /* Uncomment this section and comment out the current Application_Start to use this
         * configuration */
        //protected void Application_Start()
        //{
        //    MvcApplication.RegisterRoutes(RouteTable.Routes);

        //    var container = new Container();

        //    container.Configure(x =>
        //        x.AddRegistry<Ploeh.Samples.Commerce.Web.StructureMap.CommerceRegistry>());

        //    var controllerFactory =
        //        new Ploeh.Samples.Commerce.Web.StructureMap.StructureMapControllerFactory(container);

        //    ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        //}
        #endregion

        #region Spring.NET
        /* Uncomment this section and comment out the current Application_Start to use this
         * configuration */
        //protected void Application_Start()
        //{
        //    MvcApplication.RegisterRoutes(RouteTable.Routes);

        //    var fileName = this.Server.MapPath("springconfig.xml");
        //    var context = new XmlApplicationContext(fileName);

        //    var controllerFactory =
        //        new Spring.Net.SpringNetControllerFactory(context);

        //    ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        //}
        #endregion

        #region autofac, convention-based
        /* Uncomment this section and comment out the current Application_Start to use this
         * configuration */
        //protected void Application_Start()
        //{
        //    MvcApplication.RegisterRoutes(RouteTable.Routes);

        //    var builder = new ContainerBuilder();

        //    builder.RegisterModule<Ploeh.Samples.Commerce.Web.Autofac.CommerceModule>();

        //    var controllerFactory =
        //        new Ploeh.Samples.Commerce.Web.Autofac.AutofacControllerFactory(builder.Build());

        //    ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        //}
        #endregion

        #region Unity, Code as Configuration
        /* Uncomment this section and comment out the current Application_Start to use this
         * configuration */
        //protected void Application_Start()
        //{
        //    MvcApplication.RegisterRoutes(RouteTable.Routes);

        //    var container = new UnityContainer();
        //    container.AddNewExtension<Ploeh.Samples.Commerce.Web.Unity.CommerceContainerExtension>();

        //    var controllerFactory =
        //        new Ploeh.Samples.Commerce.Web.Unity.UnityControllerFactory(container);

        //    ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        //}
        #endregion

        #region Unity, based on web.config
        /* Uncomment this section and comment out the current Application_Start to use this
         * configuration */
        //protected void Application_Start()
        //{
        //    MvcApplication.RegisterRoutes(RouteTable.Routes);

        //    var container = new UnityContainer();
        //    container.LoadConfiguration();

        //    var controllerFactory =
        //        new Ploeh.Samples.Commerce.Web.Unity.UnityControllerFactory(container);

        //    ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        //}

        #endregion

        #region MEF
        /* Uncomment this section and comment out the current Application_Start to use this
         * configuration */
        //protected void Application_Start()
        //{
        //    MvcApplication.RegisterRoutes(RouteTable.Routes);

        //    var catalog = new Ploeh.Samples.Commerce.Web.Mef.CommerceCatalog();
        //    var container = new CompositionContainer(catalog);

        //    var controllerFactory =
        //        new Ploeh.Samples.Commerce.Web.Mef.MefControllerFactory(container);

        //    ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        //}
        #endregion
    }
}
