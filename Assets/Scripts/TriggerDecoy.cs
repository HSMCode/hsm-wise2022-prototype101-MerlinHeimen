using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDecoy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Collision

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Robot")
        {
            Debug.Log("Oh no! You hit a Decoy!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
