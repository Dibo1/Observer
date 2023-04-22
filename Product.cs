using System.Collections.Generic;
using System.Linq;


namespace Observer
{
     class Product : IObservable
    {
        private List<IObserver> observers;
        private double price;
        public Product(double p)
        {
            price = p;
            observers = new List<IObserver>();  
        }
        public void Notify()
        {
            foreach (IObserver o in observers.ToList())
                o.Update(price);
        }
        public void ChangePrice (double p)
        {
            price = p;
            Notify();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);    
        }
    }
}
