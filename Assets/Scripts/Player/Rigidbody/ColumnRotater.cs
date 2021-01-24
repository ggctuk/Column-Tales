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
            transform.Rotate(Vector3.up * speed * Time.deltaTime);

        //Rotate the column left - using left button
        if (Input.GetKey("left"))
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);

        //Rotate the column right - using D button
        if (Input.GetKey("d"))
            transform.Rotate(Vector3.up * speed * Time.deltaTime);

        //Rotate the column left - using A button
        if (Input.GetKey("a"))
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);

    }
}
