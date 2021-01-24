using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public Camera playerCamera;

    //Define the audio stuff.
    public AudioSource playerAudioSource;
    public AudioClip playerJumpingSound;
    public AudioClip playerAttackSound;
    public AudioClip playerHurtSound;
    public AudioClip playerDeathSound;

    //Time to define some other player controller stuff
    Transform model;

    private float currentJumps = 0; //Default number of current number of jumps executed. 0 means character hasn't jumped by default

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
