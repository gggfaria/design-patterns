namespace DesignPattern.Behavioral.TemplateMethod
{
    //Concrete class that overrides all of the steps
    public class DebtInstallment : Debt
    {
        public DebtInstallment(decimal debtValue, int installmentNumber) : base(debtValue)
        {
            InstallmentNumber = installmentNumber;
        }

        public int InstallmentNumber { get; private set; }


        //overridening the abstract method - one step
        public override decimal GetInterest()
        {
            return DebtValue * 0.05m;
        }

    }
}
