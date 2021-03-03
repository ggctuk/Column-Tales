using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnRotater : MonoBehaviour
{
    public float speed;

    void Update()
    {

        //Rotate the column right - using right button
        if (Input.GetKey("right"))
            TurnRight();

        //Rotate the column left - using left button
        if (Input.GetKey("left"))
            TurnLeft();

        //Rotate the column right - using D button
        if (Input.GetKey("d"))
            TurnRight();

        //Rotate the column left - using A button
        if (Input.GetKey("a"))
            TurnLeft();

    }

    void TurnLeft()
    {
        transform.Rotate(-Vector3.up * speed * Time.deltaTime);
    }

    void TurnRight()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
