namespace DesignPattern.Behavioral.Observer.Observers
{   
    public class Subscriber : IObserver
    {
        public Subscriber(string name, ISubject subject)
        {
            Name = name;
            Subject = subject;
            Subject?.RegisterOberver(this);
        }

        public string Name { get; private set; }
        public ISubject Subject { get; private set; }
        public bool HasBeenUpdated { get; set; }

        public string GetName()
        {
            return Name;
        }

        public void Update(string mensagem)
        {
            HasBeenUpdated = EmailSender.NotifyMessage(mensagem, this);
        }

    }
}
