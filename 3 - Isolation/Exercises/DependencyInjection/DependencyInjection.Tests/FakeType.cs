namespace DependencyInjection.Tests
{
    internal class FakeType : IFakeType
    {
        public bool IsWorking()
        {
            return true;
        }
    }
}