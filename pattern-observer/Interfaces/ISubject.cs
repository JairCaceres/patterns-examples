
namespace pattern_observer.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

}
