using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.View;

public interface IObserver
{

    void UpdateObserver(ISubject subject);
}
