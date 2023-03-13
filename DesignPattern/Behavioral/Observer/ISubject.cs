namespace DesignPattern.Behavioral.Observer
{
    //Subject is responsible to nofity its observables, also register and remove them
    public interface ISubject
    {
        void RegisterOberver(IObserver oberser);
        void RemoveObserver(IObserver oberser);
        bool HasObserver(params IObserver[] oberser);
        void NotifyObservers();
        bool HasNotifyAll();
    }
}
