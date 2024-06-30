using pattern_observer.Interfaces;

namespace pattern_observer
{
    public class PromotionNotifier : ISubject
    {
        private List<IObserver> _observers;
        private string _promotion;

        public PromotionNotifier()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_promotion);
            }
        }

        public void NewPromotion(string promotion)
        {
            _promotion = promotion;
            NotifyObservers();
        }
    }
}
