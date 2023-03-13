namespace DesignPattern.Behavioral.Observer
{
    //Observers must know the object of interest and define the method to update him with the subject
    public interface IObserver
    {
        void Update(string mensagem);
        string GetName();
        public bool HasBeenUpdated { get; protected set; }

    }
}

