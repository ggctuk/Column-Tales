using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpScript : MonoBehaviour
{
    public Rigidbody characterRigidbody;
    public float jumpHeight = 10.0f;
    public float currentJumps = 0;
    public float maxJumps = 1;

    private void OnCollisionEnter(Collision collision)
    {
            CharacterIsGrounded(); //If the character is on the ground, then reset the number of current jumps to zero as defined in CharacterIsGrounded
            Debug.Log("Character is grounded");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump") && currentJumps < maxJumps)
        {
            characterRigidbody.AddForce(Vector3.up * jumpHeight);
            currentJumps++;
            Debug.Log("Character is not grounded");
        }
    }

    void CharacterIsGrounded ()
    {
        currentJumps = 0;
    }
}
