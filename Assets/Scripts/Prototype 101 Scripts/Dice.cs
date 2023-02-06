using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    //Variable to store the number from the "dice roll"
    public int randomnr = 0;

   /* Lucky numbers from the "Three numbers" assignment
    public int lucky1 = 1;
    public int lucky3 = 3;
    public int lucky5 = 5;
   */

    //Array with Lucky numbers
    public int[] luckyNrs = {7, 5, 23, 15, 45, 36, 11, 49};

    //Status of win condition
    public bool winCondition = false;

    //Attaches source clip for audio playback
    public AudioSource audioSource;
    public AudioClip concreteExplosion;

    //Particle System
    public ParticleSystem confetti;
    

    // Update is called once per frame
    void Update()
    {

        //Rolls the dice and checks for win condition
        if (Input.GetKeyDown("f"))
        {
            //"Roll" a random number
            randomnr = Random.Range(1, 51);
            Debug.Log("The Dice was rolled and landed at: " + randomnr);

            //Check for win condition
            for (int i = 0; i < 8; i++)
            {
                if (randomnr == luckyNrs[i])
                {
                    Debug.Log("+++ YOU WON +++");
                    winCondition = true;
                    audioSource.Play();
                    confetti.Play();
                }
                
            }

            //Feedback to the player if win condition = flase
            if (winCondition == false)
            {
                Debug.Log("YOU LOST :(");
            }
        }

        


            /* Checks for lucky numbers from the "Three numbers" assignment
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
            */

        

        
    }
}
