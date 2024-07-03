using ObserverPatternPoC.Observers;

namespace ObserverPatternPoC.Services;
public class DataService : IObservable
{
    private List<IObserver> _observers = new List<IObserver>();

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(string data)
    {
        foreach (var observer in _observers)
        {
            observer.Update(data);
        }
    }

    public void ChangeData(string newData)
    {
        NotifyObservers(newData);
    }
}
