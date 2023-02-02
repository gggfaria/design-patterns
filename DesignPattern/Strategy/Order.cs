namespace DesignPattern.Strategy
{
    public class Order
    {
        public Order(decimal value, IFreight freightRate)
        {
            Value = value;
            FreightRate = freightRate;
        }

        public decimal Value { get; private set; }
        public IFreight FreightRate { get; private set; }

    }
}
