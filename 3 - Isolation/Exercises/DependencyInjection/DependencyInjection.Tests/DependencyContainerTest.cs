using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DependencyInjection.Tests
{
    [TestClass]
    public class DependencyContainerTest
    {
        [TestInitialize]
        public void Setup()
        {
            DependencyContainer.Clear();
        }

        [TestCleanup]
        public void Teardown()
        {
            DependencyContainer.Clear();
        }

        [TestMethod]
        [ExpectedException(typeof(NotRegisteredTypeException))]
        public void StaticGetRegisteredInstanceMustThrowWhenThereIsNoDependencyRegisteredForThatType()
        {
            DependencyContainer.GetRegisteredInstance<IFakeType>();
        }

        [TestMethod]
        [ExpectedException(typeof(NotRegisteredTypeException))]
        public void StaticCreateNewInstanceMustThrowWhenThereIsNoDependencyRegisteredForThatType()
        {
            DependencyContainer.CreateNewInstance<IFakeType>();
        }

        [TestMethod]
        public void StaticGetRegisteredInstanceMustReturnTheRegisteredInstanceForThatType()
        {
            var registeredInstance = new FakeType();
            DependencyContainer.Register<IFakeType>(registeredInstance);
            var instance = DependencyContainer.GetRegisteredInstance<IFakeType>();
            Assert.AreEqual(registeredInstance, instance);
        }

        [TestMethod]
        public void StaticCreateNewInstanceMustReturnTheRegisteredTypeInstancedWhenTheDependenceIsRegisteredForThatType()
        {
            var registeredType = typeof(FakeType);
            DependencyContainer.Register<IFakeType>(registeredType);
            var instance = DependencyContainer.CreateNewInstance<IFakeType>();
            Assert.IsInstanceOfType(instance, registeredType);
        }

        [TestMethod]
        public void StaticCreateNewInstanceMustReturnTheRegisteredTypeInstancedAndExecutableWhenTheDependenceIsRegisteredForThatType()
        {
            var registeredType = typeof(FakeType);
            DependencyContainer.Register<IFakeType>(registeredType);
            var instance = DependencyContainer.CreateNewInstance<IFakeType>();
            Assert.IsTrue(instance.IsWorking());
        }

        [TestMethod]
        [ExpectedException(typeof(NotRegisteredTypeException))]
        public void ClearMethodMustRemoveTheRegisteredTypes()
        {
            var registeredType = typeof(FakeType);
            DependencyContainer.Register<IFakeType>(registeredType);
            DependencyContainer.Clear();
            DependencyContainer.CreateNewInstance<IFakeType>();
        }

        [TestMethod]
        [ExpectedException(typeof(NotRegisteredTypeException))]
        public void ClearMethodMustRemoveTheRegisteredInstances()
        {
            var registeredInstance = new FakeType();
            DependencyContainer.Register<IFakeType>(registeredInstance);
            DependencyContainer.Clear();
            DependencyContainer.GetRegisteredInstance<IFakeType>();
        }
    }
}
