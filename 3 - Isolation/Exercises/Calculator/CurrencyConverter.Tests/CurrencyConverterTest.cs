using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Currency.Tests
{
    [TestClass]
    public class CurrencyConverterTest
    {
        [TestMethod]
        public void ConvertEurosToDollarsMustReturnTheEurosMultipliedBy1Point2()
        {
            var converter = new CurrencyConverter();

            var dollars = converter.ConvertEurosToDollars(1);

            Assert.AreEqual(1.2, dollars);
        }

        [TestMethod]
        public void ConvertDollarsToEurosMustReturnTheDollarsDividedBy1Point2()
        {
            var converter = new CurrencyConverter();

            var euros = converter.ConvertDollarsToEuros(1.2);

            Assert.AreEqual(1, euros);
        }
    }
}
