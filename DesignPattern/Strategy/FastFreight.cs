namespace DesignPattern.Strategy
{
    public class FastFreight : IFreight
    {
        public decimal GetFreightRate(decimal value)
        {
            return value * 0.05m;
        }
    }
}
