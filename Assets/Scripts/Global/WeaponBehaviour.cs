using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    public float speed;
    public float lifeSpan;

    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        Destroy(gameObject, lifeSpan);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
