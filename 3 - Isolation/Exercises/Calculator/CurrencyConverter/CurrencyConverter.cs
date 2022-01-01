using Currency;

namespace Currency
{
    public class CurrencyConverter : ICurrencyConverter
    {
        public double ConvertEurosToDollars(double euros)
        {
            return euros * 1.2;
        }

        public double ConvertDollarsToEuros(double dollars)
        {
            return dollars / 1.2;
        }
    }
}
