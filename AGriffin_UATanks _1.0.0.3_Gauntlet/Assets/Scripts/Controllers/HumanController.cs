using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : Controller
{
    public TankData pawn;
    public TankShooter projectile;

    // Start is called before the first frame update
    public override void Start()
    {

    }

    // Update is called once per frame
    public override void Update()
    {
        // Vector is 0, changed according to player input See lines 19;27, 29;37
        Vector3 moveDirection = Vector3.zero;       

        //Player Input = Forward/Backward
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection.z = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDirection.z = -1;
        }

        // Player Input = Turn
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDirection.x = -1;
        }

        // pawn calls mover(TankData.cs) < Calls Move()(TankMover.cs)
        pawn.mover.Move(moveDirection);

    }
}
