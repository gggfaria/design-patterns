namespace DesignPattern.Behavioral.Strategy
{
    public interface IFreight
    {
        //every strategy will be responsible to give a freight rate
        decimal GetFreightRate(decimal value);
    }
}
