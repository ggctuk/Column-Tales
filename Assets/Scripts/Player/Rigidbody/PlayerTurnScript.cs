using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnScript : MonoBehaviour
{
    public float characterTurnSpeed;
    public Rigidbody characterRigidbody;
    Transform model;

    void Start()
    {
        model = transform.Find("Model");
    }

    void Update()
    {
        //Rotate the character right - using right button
        if (Input.GetKey("right"))
            flipCharacterRight();

        //Rotate the character left - using left button
        if (Input.GetKey("left"))
            flipCharacterLeft();


        //Rotate the character right - using D button
        if (Input.GetKey("d"))
            flipCharacterRight();

        //Rotate the character left - using A button
        if (Input.GetKey("a"))
            flipCharacterLeft();

    }

    public void flipCharacterLeft()
    {
        transform.eulerAngles = new Vector3(0, 180, 0);
        Debug.Log("Character is now facing left");
    }

    public void flipCharacterRight()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
        Debug.Log("Character is now facing right");
    }
}
