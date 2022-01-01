using System;

namespace DependencyInjection
{
    public class MockingContext : IDisposable
    {
        public void Dispose()
        {
            DependencyContainer.Clear();
        }

        public void InstallMock<T>(T type)
        {
            DependencyContainer.Register(type);
        }
    }
}
