using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConstantEvent : MonoBehaviour
{
    public UnityEvent constantEvent;
    
    void Update()
    {
        constantEvent.Invoke();
    }
}
