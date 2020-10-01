using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDeath : MonoBehaviour
{
    public UnityEvent playerIsDead;
    public UnityEvent respawn;
    public FloatData playerHealth;
    void Update()
    {
        if (playerHealth.value <= 0)
        {
            playerIsDead.Invoke();
            StartCoroutine("Delay");
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.05f);
        respawn.Invoke();
    }
}
