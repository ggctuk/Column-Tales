using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public AudioClip TakeDamageSound;
    public AudioClip HealSound;
    public AudioClip DeathSound;
    public AudioSource CharacterAudioSource;

    [SerializeField]
    protected int health;

    [SerializeField]
    protected int totalHealth;

    void Start()
    {
        CharacterAudioSource = GetComponent<AudioSource>(); //Setting up the audio source for character hurt/die sounds
    }

    //We're setting up the ability to take damage from here.

    public void TakeDamage(int amount)
    {
        health -= amount;
        health = Mathf.Clamp(health, 0, totalHealth);
        CharacterAudioSource.PlayOneShot(TakeDamageSound);
        //If the character reaches a value equal to zero or a minus value, then they die
        if (health <=0)
        {
            Die();
        }
    }

    //Next up is the ability to add health for things like powerups

    public void AddHealth(int amount)
    {
        health += amount;
        health = Mathf.Clamp(health, 0, totalHealth);
        CharacterAudioSource.PlayOneShot(HealSound);
    }

    public void MultiplyHealth(int amount)
    {
        health *= amount;
    }

    public virtual void Die()
    {
        CharacterAudioSource.PlayOneShot(DeathSound);
        //At this point when we have animations we'll set in an animation the character plays first before they die
        //For now, we'll just destroy the object
        Destroy(gameObject);
    }

}
