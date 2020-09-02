using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Intdata : ScriptableObject
{
    public int value;

    public void ChangeValue(int number)
    {
        value += number;
    }

    public void SetValue(int number)
    {
        value = number;
    }
}
