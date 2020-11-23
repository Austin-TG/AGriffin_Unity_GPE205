using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour
{
    public TankData data;
    public CharacterController cC;

    // Start is called before the first frame update
    void Start()
    {
        // IF data is NULL on START, Connects to TankData
        if (data == null)
        {
            data = GetComponent<TankData>();
        }
        // IF cC is NULL on START, Connects to CharacterController
        if (cC == null)
        {
            cC = GetComponent<CharacterController>();
        }
    }

    public void Move (Vector3 moveDirection)
    {
        // Process Movement
        // Rotation
        transform.Rotate(0, moveDirection.x * data.rotateSpeed * Time.deltaTime, 0);

        // Movement
        Vector3 moveVector = Vector3.zero;
        moveVector.z = moveDirection.z * data.moveSpeed;
        moveVector = transform.TransformDirection(moveVector);
        cC.SimpleMove(moveVector);

    }
}
