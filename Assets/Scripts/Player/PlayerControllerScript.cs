using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    //Define the character controller first and foremost
    public Camera playerCamera;
    public CharacterController characterController;

    //Define the audio stuff.
    public AudioSource playerAudioSource;
    public AudioClip playerJumpingSound;
    public AudioClip playerAttackSound;
    public AudioClip playerHurtSound;
    public AudioClip playerDeathSound;

    //Time to define some other player controller stuff
    Transform model;

    //Define values for things like speed, jump and character gravity
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float maxJumps = 1; //The maximum n umber of times the character can jump. 1 is from ground. Any more is from the air.
    public int rotationAngle; //Player rotation angle - for the column.

 //   public GameObject playerModel; //The player model object.

    private Vector3 moveDirection = Vector3.zero;
    private float currentSpeed = 0.0f; //Default movement speed. 0 means character is standing when spawned
    private float currentJumps = 0; //Default number of current number of jumps executed. 0 means character hasn't jumped by default
    
    //Okay, so let's now define the character controller stuff at the start of spawning
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        model = transform.Find("Model"); //The actual player model must be called this! If you change this, change the name of the child model in the Player object
    }

    //Now for when the player controls the character's movement.
    void Update()
    {
        moveDirection.x = Input.GetAxis("Horizontal") * speed;

        //Now the directional left-right stuff
        if (Input.GetAxis ("Horizontal") < 0)
        {
            Vector3 velocity = Vector3.zero;
            //This next line sets the default rotation based on player's direction
            Vector3 desiredAngles = new Vector3(0, model.eulerAngles.y + rotationAngle * Time.deltaTime, 0);
            model.localEulerAngles = (Vector3.SmoothDamp(model.localEulerAngles, desiredAngles, ref velocity, 1 * Time.deltaTime));
            characterController.Move(model.transform.forward * speed * Time.deltaTime);
        }

        else if (Input.GetAxis("Horizontal") > 0)
        {
            Vector3 velocity = Vector3.zero;
            //This next line sets the default rotation based on player's direction
            Vector3 desiredAngles = new Vector3(0, model.eulerAngles.y + rotationAngle * Time.deltaTime, 0);
            model.localEulerAngles = (Vector3.SmoothDamp(model.localEulerAngles, desiredAngles, ref velocity, 1 * Time.deltaTime));
            characterController.Move(model.transform.forward * speed * Time.deltaTime);
        }

        //Now for the jumping stuff

        if (characterController.isGrounded)
        {
            currentJumps = 0; //If the character is on the ground, then reset the number of current jumps to zero
        }
        else
        {
            moveDirection.y -= gravity * Time.deltaTime; //If the character is NOT grounded, then move them along the Y axis according to gravity
        }

        //Now we execute the jump when the character hits the jump key
        if (Input.GetButtonDown("Jump") && currentJumps < maxJumps) //If the current number of jumps is less than max when Jump is pressed
        {
            playerAudioSource.PlayOneShot(playerJumpingSound);
            moveDirection.y = jumpSpeed;
            currentJumps ++;
        }

        //If we are in the air, apply gravity to the jump. After all, what goes up must come down.
        if (characterController.isGrounded == false)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        //And now we get the actual character controller moving!
 //       characterController.Move(model.transform.forward * Time.deltaTime);

    }
}
