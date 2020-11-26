using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform cameraTarget = null;
    public Vector3 followDamp = new Vector3(25.0F, 25.0F, 0.0F);

    private float currentVelocityX = 0;
    private float currentVelocityY = 0;
    private float currentVelocityZ = 0;

    private void LateUpdate()
    {
        Vector3 position = transform.position;
        position.x = Mathf.SmoothDamp(position.x, cameraTarget.transform.position.x, ref currentVelocityX, followDamp.x * Time.deltaTime);
        position.y = Mathf.SmoothDamp(position.y, cameraTarget.transform.position.y, ref currentVelocityX, followDamp.y * Time.deltaTime);
        position.z = Mathf.SmoothDamp(position.z, cameraTarget.transform.position.z, ref currentVelocityX, followDamp.z * Time.deltaTime);
    }
}
