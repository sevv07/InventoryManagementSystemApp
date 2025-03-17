using System.Collections.Generic;
using WinFormsApp1;

public class StockNotifier
{
    private List<IStockObserver> observers = new List<IStockObserver>();

    public void AddObserver(IStockObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyObservers(string productName, int quantity)
    {
        foreach (var observer in observers)
        {
            observer.OnStockLow(productName, quantity);
        }
    }

    public void CheckStock(string productName, int quantity)
    {
        if (quantity < 5) // Eşik değer: 5
        {
            NotifyObservers(productName, quantity);
        }
    }
}
