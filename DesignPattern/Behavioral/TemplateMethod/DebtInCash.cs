namespace DesignPattern.Behavioral.TemplateMethod
{
    //Concrete class that overrides all of the steps
    public class DebtInCash : Debt
    {
        public DebtInCash(decimal debtValue) : base(debtValue)
        {
        }

        //overridening the abstract method - one step
        public override decimal GetInterest()
        {
            return 0;
        }

    }
}
