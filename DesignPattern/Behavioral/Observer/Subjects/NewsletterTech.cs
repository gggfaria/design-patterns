namespace DesignPattern.Behavioral.Observer.Subjects
{
    public class NewsletterTech : ISubject
    {
        private List<IObserver> _observers = new();
        private List<string> _messages = new();
        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_messages.Last()));
        }

        public void RegisterOberver(IObserver oberser)
        {
            _observers.Add(oberser);
        }

        public void RemoveObserver(IObserver oberser)
        {
            _observers.Remove(oberser);
        }

        public void AddMessage(string message)
        {
            _messages.Add(message);
            NotifyObservers();
        }

        public bool HasNotifyAll()
        {
            return !_observers.Select(p => p.HasBeenUpdated).Any(p => p == false);
        }

        public bool HasObserver(params IObserver[] obersers)
        {
            var intersectedlist = _observers.Intersect(obersers);
            return intersectedlist.Count() == obersers.Length;
        }
    }
}
