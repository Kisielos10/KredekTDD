using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    public class DependencyContainer
    {
        private static Dictionary<Type, object> instances = new Dictionary<Type, object>();
        private static Dictionary<Type, Type> instantiables = new Dictionary<Type, Type>();

        public static T GetRegisteredInstance<T>()
        {
            if (!instances.ContainsKey(typeof(T))) throw new NotRegisteredTypeException("Not registered type " + typeof(T).ToString());
            return (T)(instances[typeof(T)]);
        }

        public static void Register<T>(T instance)
        {
            instances[typeof(T)] = instance;
        }

        public static void Register<T>(Type registeredType)
        {
            instantiables[typeof(T)] = registeredType;
        }

        public static T CreateNewInstance<T>()
        {
            if (!instantiables.ContainsKey(typeof(T))) throw new NotRegisteredTypeException("Not registered type " + typeof(T).ToString());
            var type = instantiables[typeof(T)];
            var instance = type.GetConstructor(new Type[0]).Invoke(new object[0]);
            return (T)instance;
        }

        public static void Clear()
        {
            instances.Clear();
            instantiables.Clear();
        }
    }
}
