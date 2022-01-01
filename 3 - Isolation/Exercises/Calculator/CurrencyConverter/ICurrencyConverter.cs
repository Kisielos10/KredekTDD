namespace Currency
{
    public interface ICurrencyConverter
    {
        double ConvertEurosToDollars(double euros);
        double ConvertDollarsToEuros(double dollars);
    }
}
