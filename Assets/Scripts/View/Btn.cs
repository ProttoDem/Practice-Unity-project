using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Scripts.Model;

namespace Scripts.View
{
    public abstract class Btn : MonoBehaviour, ISubject
    {
        [HideInInspector]
        public abstract IProduct product { get; set; }

        
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {

            this._observers.Add(observer);
        }

        public void clicked()
        {
            this.Notify();
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);

        }
           
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.UpdateObserver(this);
            }
        }

        public IProduct getProduct()
        {
            return product;
        }
    }
}
