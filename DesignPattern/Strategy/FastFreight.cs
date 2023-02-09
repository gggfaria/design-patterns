namespace DesignPattern.Strategy
{
    public class FastFreight : IFreight
    {
        //Concrete strategy to use a type of freight
        public decimal GetFreightRate(decimal value)
        {
            return value * 0.05m;
        }
    }
}
