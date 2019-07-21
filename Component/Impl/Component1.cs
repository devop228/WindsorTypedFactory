using Castle.Core.Logging;

namespace WindsorTypedFactory.Component.Impl
{
    public class Component1 : IDummyComponent
    {
        private ILogger _logger;

        public Component1(ILoggerFactory factory) {
            _logger = factory.Create(GetType().Name);
        }

        public void Dispose()
        {
            _logger.Info("Dispose called.");
        }

        public void DoSomethingDummy()
        {
            _logger.Info("DoSomethingDummy called.");
        }
    }
}