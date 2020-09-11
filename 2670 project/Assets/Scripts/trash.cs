using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    public int loopCountdown;
    // Start is called before the first frame update
    private IEnumerator Timer()
    {
        while (loopCountdown > 0)
        {
            print(loopCountdown);
            loopCountdown--;
            yield return new WaitForSeconds(1);
        }
    }
    
    void Start()
    {
        StartCoroutine(Timer());
    }
}
