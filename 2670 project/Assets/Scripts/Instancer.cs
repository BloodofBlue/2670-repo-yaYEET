﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public GameObject prefab;
    
    //make a method to call the instance

    private void Start()
    {
        var location = transform.position;
        var rotationDirection = new Vector3(0,45,0);
        Instantiate(prefab, location, Quaternion.Euler(rotationDirection));
    }
}