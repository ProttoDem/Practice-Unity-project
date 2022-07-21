using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Model;
using Scripts.View;

public interface ISubject
{
    void Attach(IObserver observer);
       
    void Detach(IObserver observer);


    void Notify();

    IProduct getProduct();
    }
