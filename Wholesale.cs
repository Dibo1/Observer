using System;

namespace Observer
{
    class Wholesale :IObserver
    {
        private IObservable product;
        public Wholesale(IObservable obj)
        {
            product = obj;
            obj.AddObserver(this);
        }
        public void Update(double p)
        {
            if (p < 300)
            {
                Console.WriteLine("Оптовик закупил товар поцене " + p);
            }
        }
    }
}
