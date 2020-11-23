using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour
{
    // Variables for Tanks Movement and Fire Data
    public float moveSpeed;
    public float rotateSpeed;
    public float fireRate;

    // Connecting classes to variables for THIS class
    public TankMover mover;
    public TankShooter shooter;
    public TankHealth health;



    // Start is called before the first frame update
    void Start()
    {
        // get components for each variable for inspector
        mover = GetComponent<TankMover>();
        shooter = GetComponent<TankShooter>();
        health = GetComponent<TankHealth>();
    }
}
