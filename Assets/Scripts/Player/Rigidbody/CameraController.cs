using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target = null;
    public Vector3 smoothDamp = Vector3.zero;

    private Vector3 currentVelocity = Vector3.zero;

    void Update()
    {
        Vector3 position = transform.position;
        if (smoothDamp.x > 0)
        {
            position.x = Mathf.SmoothDamp(position.x, target.position.x, ref currentVelocity.x, smoothDamp.x * Time.deltaTime);
        }
        if (smoothDamp.y > 0)
        {
            position.y = Mathf.SmoothDamp(position.y, target.position.y, ref currentVelocity.y, smoothDamp.y * Time.deltaTime);
        }
        if (smoothDamp.z > 0)
        {
            position.z = Mathf.SmoothDamp(position.z, target.position.z, ref currentVelocity.z, smoothDamp.z * Time.deltaTime);
        }
        transform.position = position;
    }
}
