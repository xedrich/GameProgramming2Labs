using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovement : MonoBehaviour
{
     float speed = 200.0f;
     Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // so player doesnt clip through the trap
        Quaternion deltaRotation = Quaternion.Euler(new Vector3(0,1,0)* Time.deltaTime * speed);
        rigidBody.MoveRotation(rigidBody.rotation * deltaRotation);
        
        // transform.Rotate(new Vector3(0,1,0) * Time.deltaTime * speed);

    }
}
