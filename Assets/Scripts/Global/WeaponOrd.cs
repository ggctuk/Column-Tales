using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Here is where we have weapon ordnance setup
public class WeaponOrd : MonoBehaviour
{
    public float speed;

    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
