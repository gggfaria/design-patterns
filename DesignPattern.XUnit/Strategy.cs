using DesignPattern.Strategy;

namespace DesignPattern.XUnit
{
    public class Strategy
    {
        [Theory]
        [InlineData(50, 2.5f)]
        [Trait("Pattern", "Strategy")]
        public void CreateOrder_FastFreight_ReturnValueValid(decimal value, decimal valueFreight)
        {
            var order = new Order(value, new FastFreight());
            var calculedFreight = order.FreightRate.GetFreightRate(value);

            Assert.Equal(valueFreight, calculedFreight);
        }

        [Theory]
        [InlineData(50, 1.25f)]
        [Trait("Pattern", "Strategy")]
        public void CreateOrder_CommonFreight_ReturnValueValid(decimal value, decimal valueFreight)
        {
            var order = new Order(value, new CommonFreight());
            var calculedFreight = order.FreightRate.GetFreightRate(value);

            Assert.Equal(valueFreight, calculedFreight);
        }
    }
}