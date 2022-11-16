using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roboter : MonoBehaviour
{

    public float stepFwd = 1f;
    public float stepBack = -1f;
    public float stepLeft = 1f;
    public float stepRight = -1f;
    public float turnRight = 90f;
    public float turnLeft = -90f;

    public GameObject Robot;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {

            //move robot forward
            transform.Translate(0, 0, stepFwd);

        }

        if (Input.GetKeyDown("s"))
        {

            //move robot backward
            transform.Translate(0, 0, stepBack);

        }


    //rotate on y-axis

        if (Input.GetKeyDown("e"))
        {

            transform.Rotate(0, turnRight, 0);
        }

        if (Input.GetKeyDown("q"))
        {

            transform.Rotate(0, turnLeft, 0);
        }

    //Jump

        if (Input.GetKeyDown("space"))
        {
            transform.Translate(0, 2, 0);
        }

        if (Input.GetKeyUp("space"))
        {
            transform.Translate(0, -2, 0);
        }

    

    }
}
