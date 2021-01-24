using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    public Transform attackPoint; //Defines the model/hardpoint the attack extends from
    public GameObject attackObject; //Defines the spawned attack object - sword, claw, etc

    public AudioClip attackSound;
    public AudioSource characterSource;
    bool playAudio = false;

    [Range(0.1f, 300f)]
    public float attacksPerSecond;
    private float attackDelay;
    public float attackTimer;

    void Start()
    {
        attackDelay = 1.0f / attacksPerSecond;
        characterSource = GetComponent<AudioSource>();
    }


    public void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Attack();
        }
        else if (attackTimer > 0)
        {
            attackTimer = Mathf.Clamp(attackTimer - Time.deltaTime, 0.0f, attackDelay);
        }
    }

    //The actual attack stuff
    private void Attack()
    {
        attackTimer -= Time.deltaTime;

        while (attackTimer <= 0)
        {
            Instantiate(attackObject, attackPoint.transform.position, attackPoint.transform.rotation);
            attackTimer += attackDelay;
            characterSource.PlayOneShot(attackSound);
        }
    }
}
