using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Scripts.View;

namespace Scripts
{
    class Controller : MonoBehaviour, IObserver
    {

        [SerializeField]
        ModelController model;
        [SerializeField]
        CartController _cartController;
        
        [SerializeField]
        CPUBtn1 cpubtn1;


        void Start()
        {
            cpubtn1.Attach(this);
            cpubtn1.Attach(model);
        }
        public void UpdateObserver(ISubject subject)
        {
            
            switch (/*subject.getProduct().getName()*/ "")
            {
                case "AMDCPU":

                    _cartController.LoadCartButton(subject.getProduct());
                    
                    break;
                default:
                    _cartController.LoadCartButton(subject.getProduct());
                    break;
            }

        }
    }
}
