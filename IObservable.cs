﻿

namespace Observer
{
    internal interface IObservable 
        
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void Notify();
    }

}
