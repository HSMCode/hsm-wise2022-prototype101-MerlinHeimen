using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryDbug : MonoBehaviour
{

    //The Legend of Darth Plagueis Array
    string[] sithLegend = { "<i>Did you ever hear the tragedy of Darth Plagueis the wise?</i>", "<i>It's not a story the Jedi would tell you</i>", "<i>It's a Sith legend.</i>", "<i>Darth Plagueis... was a Dark Lord of the Sith so powerful and so wise, he could use the Force to influence the midi-chlorians... to create... life.</i>", "<i>He had such a knowledge of the dark side, he could even keep the ones he cared about... from dying.</i>", "<i>He became so powerful, the only thing he was afraid of was... losing his power. Which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew. Then his apprentice killed him in his sleep.</i>", "<i>It's ironic. He could save others from death, but not himself.</i>", "<i>You may ask if it's possible to learn this power? Well...</i>", "<i>Not for a Jedi.</i>" };

    //Array index
    private int x = 0;

    //Text intervall
    private int y;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("There may be an Error in your Script!");
        Debug.LogError("Error not found.");
        Debug.Log("<b>Remember the semicolons!</b>");
        Debug.Log("Press <b><i> W </i></b> to Start");

        
    }

    // Update is called once per frame
    void Update()
    {
        //Press W to tell the story
        if (Input.GetKeyDown("w") && x <= 8){


            Debug.LogError(sithLegend[x]);

            x++;

            if (x == 1)
            {
                Debug.Log("Press <b><i> W </i></b> to continue.");
            }
            
        }

    }
}
