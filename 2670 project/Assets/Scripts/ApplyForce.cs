using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rBody;
    public float force = 30f;
    public Vector3Data fireDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        var forceDirection = fireDirection.value;
        //forceDirection needs to be based on Player rotation
        rBody.AddRelativeForce(forceDirection * 100);
    }
}
