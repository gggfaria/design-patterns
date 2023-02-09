using DesignPattern.Behavioral.TemplateMethod;

namespace DesignPattern.XUnit.Behavioral
{
    public class TemplateMethodTest
    {
        [Theory]
        [InlineData(500f)]
        [Trait("Pattern", "Template Method")]
        public void CreateDebt_DebtInChash_ReturnValidPaymentValue(decimal value)
        {
            var debt = new DebtInCash(value);
            var paymentValue = debt.GetPaymentValue();

            Assert.Equal(paymentValue, value);
        }

        [Theory]
        [InlineData(25f, 26.25f)]
        [Trait("Pattern", "Template Method")]
        public void CreateDebt_DebtInstallment_ReturnValidPaymentValue(decimal value, decimal paymentValidValue)
        {
            var debt = new DebtInstallment(value, 5);
            var paymentValue = debt.GetPaymentValue();

            Assert.Equal(paymentValue, paymentValidValue);
        }
    }
}
