using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryDbug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Error: Error not found!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w")){
        
            Debug.Log("Error: W-Key not found!");
        }
    }
}
