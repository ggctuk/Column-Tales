using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovementDisabler : MonoBehaviour
{
    public GameObject columnObject; //Object the rotation script is attached to
    public string scriptName; //The name of the script

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Environment")
        {
            Debug.Log("Trigger picked up an environment collision");
            StopRotation();
        }
        else if (other.tag == "Enemy")
        {
            Debug.Log("Trigger picked up an enemy collision");
            StopRotation();
        }
        else if (other.tag == "Obstacle")
        {
            Debug.Log("Trigger picked up an obstacle collision");
            StopRotation();
        }
        else
        {
            Debug.Log("Trigger did not pick up a collision that needed to be detected");
            StartRotation();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object exited the trigger, rotation restarted");
        StartRotation();
    }

    private void StopRotation()
    {
        (columnObject.GetComponent(scriptName) as MonoBehaviour).enabled = false;
    }

    private void StartRotation()
    {
        (columnObject.GetComponent(scriptName) as MonoBehaviour).enabled = true;
    }
}
