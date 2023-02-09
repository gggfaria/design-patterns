namespace DesignPattern.Behavioral.TemplateMethod
{
    //Debt - abstract class - declares methods that act as steps of an algorithm, as well as the actual template method which calls these methods in a specific order.
    public abstract class Debt
    {
        protected Debt(decimal debtValue)
        {
            DebtValue = debtValue;
        }

        public decimal GetPaymentValue()
        {
            //defining an order to execute
            return DebtValue + GetInterest();
        }

        public decimal DebtValue { get; private set; }

        //abstract method that will have some implementations
        public abstract decimal GetInterest();

    }
}
