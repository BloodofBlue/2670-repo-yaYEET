using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform lookobj;

    private void Update()
    {
        transform.LookAt(lookobj);
    }
}
