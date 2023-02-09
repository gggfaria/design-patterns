namespace DesignPattern.Strategy
{
    //Order - the Context - maintains a reference to one of the concrete strategies and communicates with this object only via the strategy interface.
    public class Order
    {
        public Order(decimal value, IFreight freightRate)
        {
            Value = value;
            FreightRate = freightRate;
        }

        public decimal Value { get; private set; }

        //abstract strategy - will give the class one concrete strategy to calculate the freight
        public IFreight FreightRate { get; private set; }

    }
}
