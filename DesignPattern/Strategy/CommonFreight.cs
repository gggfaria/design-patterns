namespace DesignPattern.Strategy
{
    public class CommonFreight : IFreight
    {
        public decimal GetFreightRate(decimal value)
        {
            return value * 0.025m;
        }
    }
}
