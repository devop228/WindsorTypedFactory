namespace WindsorTypedFactory.Component
{
    using System;

    public interface IDummyComponentFactory : IDisposable
    {
        IDummyComponent Create();
        void Release(IDummyComponent component);
    }
}