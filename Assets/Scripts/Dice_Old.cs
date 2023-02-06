using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_Old : MonoBehaviour
{
    public int randomnr = 0;


    // Update is called once per frame
    void Update()
    {
        //Roll the dice
        if (Input.GetKeyDown("f"))
        {

            randomnr = Random.Range(1, 7);

            Debug.Log("The Dice was rolled and landed at: " + randomnr);

        }
    }
}
