using System;

namespace Observer
{
    class Buyer : IObserver
    {
        private IObservable product;
        public Buyer(IObservable obj)
        {
            product = obj;
            obj.AddObserver(this);
        }
        public void Update(double p)
        {
            if (p < 350)
            {
                Console.WriteLine("Покупатель закупапил товар по цене" + p);
            }
        }
    }
}
