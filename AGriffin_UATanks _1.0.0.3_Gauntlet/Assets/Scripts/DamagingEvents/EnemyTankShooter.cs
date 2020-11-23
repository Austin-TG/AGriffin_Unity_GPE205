using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankShooter : MonoBehaviour
{
    // Assign Rigidbody to projectile
    public Rigidbody projectile;

    // Assign speed to projectile
    public float speed = 4;

    // Create firerate data
    public float fireRate = .5f;
    private float nextFire = .0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextFire)
        {
            // Create time till next firerate
            nextFire = Time.time + fireRate;

            // Instantiate GameObject
            Rigidbody p = Instantiate(projectile, transform.position, transform.rotation);

            // Give GameObject velocity
            p.velocity = transform.forward * speed;
        }
    }
}
