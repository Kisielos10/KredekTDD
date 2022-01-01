namespace DependencyInjection
{
    public class ObjectFactory
    {
        public static T CreateInstance<T>()
        {
            return DependencyContainer.GetRegisteredInstance<T>();
        }
    }
}
