using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDecoy : MonoBehaviour
{
 
    //Robot hits Decoy
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Oh no! You hit a Decoy!");
        Destroy(this.gameObject);

    }

    
}
