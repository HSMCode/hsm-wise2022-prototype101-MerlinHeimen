using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryVariables : MonoBehaviour
{

    public int damage = 16;
    public int fallDamage = 27;
    public int poisonDamage = 5;
    public int fireDamage = 8;
    public int rottenFish = 10;
    public int DamageCombined;

    public string statusEffects = "You took damage from multiple sources. Total amount of damage: ";

    //Add variables, divide by 3 & print result to log
    void Start()
    {
        DamageCombined = (damage + fallDamage + poisonDamage + fireDamage + rottenFish) / 3;
        Debug.Log(DamageCombined);

        Debug.Log(statusEffects + DamageCombined);

    }
}
