namespace DesignPattern.Behavioral.Strategy
{
    public class CommonFreight : IFreight
    {
        //Concrete strategy to use a type of freight
        public decimal GetFreightRate(decimal value)
        {
            return value * 0.025m;
        }
    }
}
