using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int randomnr = 0;
    public int lucky1 = 1;
    public int lucky3 = 3;
    public int lucky5 = 5;

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

            if(randomnr == 1)
            {
                Debug.Log("***YOU WIN***");
                Debug.Log("YOUR LUCKY NUMBER IS: " + randomnr);
            }
            if (randomnr == 3)
            {
                Debug.Log("***YOU WIN***");
                Debug.Log("YOUR LUCKY NUMBER IS: " + randomnr);
            }
            if (randomnr == 5)
            {
                Debug.Log("***YOU WIN***");
                Debug.Log("YOUR LUCKY NUMBER IS: " + randomnr);
            }

        }

        
    }
}
