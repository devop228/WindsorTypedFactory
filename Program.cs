
namespace WindsorTypedFactory
{
    using Castle.Facilities.Logging;
    using Castle.Facilities.TypedFactory;
    using Castle.Services.Logging.NLogIntegration;
    using Castle.Windsor;
    using WindsorTypedFactory.Component;
    using WindsorTypedFactory.Component.Impl;
    using IocRego = Castle.MicroKernel.Registration;

    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.AddFacility<TypedFactoryFacility>();
            container.AddFacility<LoggingFacility>(f => 
                f.LogUsing<NLogFactory>()
            );
            container.Register(
                IocRego.Component.For<IDummyComponent>()
                    .ImplementedBy<Component1>()
                    .Named("SecondComponent")
                    .LifeStyle.Transient,
                IocRego.Component.For<IDummyComponentFactory>()
                    .AsFactory()
            );

            var factory = container.Resolve<IDummyComponentFactory>();
            var component = factory.Create();
            component.DoSomethingDummy();
            factory.Dispose();
        }
    }
}
