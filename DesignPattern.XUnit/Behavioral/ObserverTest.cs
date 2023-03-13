using DesignPattern.Behavioral.Observer.Observers;
using DesignPattern.Behavioral.Observer.Subjects;

namespace DesignPattern.XUnit.Behavioral
{
    public class ObserverTest 
    {
        [Fact]
        [Trait("Pattern", "Observer")]
        public void Subscribe_AddNewSubscribe_NotifySubscribers()
        {
            NewsletterTech tech = new ();
            Subscriber subscriberFrodo = new ("Frodo", tech);
            Subscriber subscriberBilbo = new ("Bilbo", tech);

            tech.AddMessage("Twitter has tech issues for second time in week");

           Assert.True(tech.HasNotifyAll() && tech.HasObserver(subscriberFrodo, subscriberBilbo));
        }

        [Fact]
        [Trait("Pattern", "Observer")]
        public void Subscribe_RemoveNewSubscribe_StopNotifySubscriber()
        {
            NewsletterTech tech = new();
            Subscriber subscriberFrodo = new("Frodo", tech);
            Subscriber subscriberBilbo = new("Bilbo", tech);

            tech.AddMessage("Twitter has tech issues for second time in week");

            Assert.True(tech.HasObserver(subscriberFrodo));

            tech.RemoveObserver(subscriberFrodo);
            tech.AddMessage("Git tips for better coding");

            Assert.False(tech.HasObserver(subscriberFrodo));
            Assert.True(tech.HasObserver(subscriberBilbo));
        }
    }
}
