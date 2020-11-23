using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public TankData data;

    // create var for AddForce
    public Rigidbody rb;
    public float thrust = 1.0f;

    public int damageProjectile = 25;

    // variable for projectile timeout period
    public float timeout = .5f;

    // Create function for OnCollision
    public void OnCollisionEnter(Collision _collision)
    {
        // Check Collision
        // Player
        if(_collision.gameObject.tag == "Player")
        {
            _collision.gameObject.GetComponent<TankHealth>().TakeDamage(damageProjectile);
        }
        // Enemy
        if(_collision.gameObject.tag == "Enemy")
        {
            _collision.gameObject.GetComponent<TankHealth>().TakeDamage(damageProjectile);
        }


        // When collision is met, gameobject is destroyed
        Destroy(gameObject);
    }
    // Create function for Rigidbody for projectile
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Create Function for foward force for GameObject's Rigidbody
    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * thrust);
    }

    // Create Function for destroy gameObject on delay/timeout
    private void Update()
    {
        Destroy(gameObject, timeout);
    }

}
