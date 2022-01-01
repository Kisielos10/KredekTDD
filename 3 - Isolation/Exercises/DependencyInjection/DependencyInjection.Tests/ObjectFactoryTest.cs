using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DependencyInjection.Tests
{
    [TestClass]
    public class ObjectFactoryTest
    {
        [TestMethod]
        public void CreateInstanceMustReturnTheInstanceInstalledByMockingContext()
        {
            IFakeType fakeType = new FakeType();
            IFakeType recoveredType;

            using(var context = new MockingContext())
            {
                context.InstallMock(fakeType);
                recoveredType = ObjectFactory.CreateInstance<IFakeType>();
            }

            Assert.AreSame(fakeType, recoveredType);
        }

        [TestMethod]
        [ExpectedException(typeof(NotRegisteredTypeException))]
        public void CreateInstanceMustNotCreateAnInstanceOfTheTypeInstalledByMockingContextOutOfTheContext()
        {
            IFakeType fakeType = new FakeType();

            using (var context = new MockingContext())
            {
                context.InstallMock(fakeType);
            }

            ObjectFactory.CreateInstance<IFakeType>();
        }
    }
}
