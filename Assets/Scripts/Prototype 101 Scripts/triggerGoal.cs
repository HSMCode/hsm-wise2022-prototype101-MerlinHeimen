using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerGoal : MonoBehaviour
{

    public AudioClip GoalSFX;
    AudioSource winSound;

    public GameObject Goal;

    public ParticleSystem yayGoal;


    void Start()
    {
        winSound = GetComponent<AudioSource>();
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("***You hit the GOAL***");
        winSound.PlayOneShot(GoalSFX, 0.5f);
        yayGoal.Play();
        DestroyGoal();
    }

    
    void DestroyGoal()
    {
        Destroy(this.gameObject, 5);
    }
    
}
