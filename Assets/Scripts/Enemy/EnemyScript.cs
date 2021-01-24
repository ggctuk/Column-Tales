using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform player; //Defines the tsrget
    public float speed = 5.0f; //Defines how fast they're going
    public float range = 1.0f; //Defines how close the player must be before the enemy spots them

    private Rigidbody myRigidBody;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        myRigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        LookAtPlayer();
        Move();
    }

    //Making the enemy face the player's direction
    private void LookAtPlayer()
    {
        Vector3 enemyToPlayer = player.position - transform.position;
        enemyToPlayer.y = 0.0f;
        Quaternion newRotation = Quaternion.LookRotation(enemyToPlayer);
        myRigidBody.MoveRotation(newRotation);
    }

    private void Move()
    {
        //If the player's position is further than the range the enemy can spot them, then ignore the player
        if (Vector3.Distance(transform.position, player.position) <= range)
        {
            return;
        }

        Vector3 velocity = transform.forward * speed * Time.deltaTime;

        myRigidBody.MovePosition(myRigidBody.position + velocity);
    }
}
