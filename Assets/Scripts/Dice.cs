using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int randomnr = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {

            randomnr = Random.Range(1, 7);

            Debug.Log("The Dice was rolled and landed at: " + randomnr);

        }
    }
}
