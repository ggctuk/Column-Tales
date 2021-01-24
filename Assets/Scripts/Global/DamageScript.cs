using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damageValue; //Set the value of the damage given by the damager

    public string targetTag = "";

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == targetTag)
        {
            other.gameObject.GetComponent<Health>().TakeDamage(damageValue);
        }
    }
}
