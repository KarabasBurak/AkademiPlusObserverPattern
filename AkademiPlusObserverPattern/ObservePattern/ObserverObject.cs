using AkademiPlusObserverPattern.DAL;
using System;
using System.Collections.Generic;

namespace AkademiPlusObserverPattern.ObservePattern
{
    public class ObserverObject
    {
        private readonly List<IObServer> _observers;

        public ObserverObject()
        {
            _observers = new List<IObServer>();
        }

        public void RegisterObserver(IObServer observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObServer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(AppUser appUser)
        {
            _observers.ForEach(x =>
            {
                x.CreateNewUser(appUser);
            });
        }
    }
}
