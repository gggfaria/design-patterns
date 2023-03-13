namespace DesignPattern.Behavioral.Observer
{
    public static class EmailSender
    {
        public static bool NotifyMessage(this string message, IObserver oberser)
        {
            Console.WriteLine($"Fake email from: {oberser.GetName()}");
            Console.WriteLine($"Fake message: {message}");
            return true;
        }

    }
}
