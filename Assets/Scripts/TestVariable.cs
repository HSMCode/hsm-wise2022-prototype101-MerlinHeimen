using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVariable : MonoBehaviour
{

    //Variables for Counting
    public int numberOne = 1;
    public int numberTwo = 2;
    public int result;
    public float resulttwo;
    public float numberEleven = 11;
    public float numberTwelve = 12;
    public string words = "Das Ergebnis von 11 + 11 ist: ";

    // Start is called before the first frame update
    void Start()
    {
        /*
        result = numberOne + numberTwo;

        Debug.Log("Das Resultat: " + result);
        */

        resulttwo = numberEleven + numberEleven;

        Debug.Log(words + resulttwo);


    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("Das Resultat:");

    }
}
