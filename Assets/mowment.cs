using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mowment : MonoBehaviour
{
    public Transform dir;
    Rigidbody rb;
    float YVelocity;

    public float speed;
    public float jumpSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, 0);

        YVelocity = rb.velocity.y;

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity += (dir.transform.forward * speed);
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.velocity = new Vector3(rb.velocity.x, YVelocity, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += (dir.transform.right * speed);
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.velocity = new Vector3(rb.velocity.x, YVelocity, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity -= (dir.transform.right * speed);
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.velocity = new Vector3(rb.velocity.x, YVelocity, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity -= (dir.transform.forward * speed);
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.velocity = new Vector3(rb.velocity.x, YVelocity, rb.velocity.z);
        }

    if (Input.GetKey(KeyCode.Space) && Physics.Raycast(transform.position, Vector3.down, 1.5f))
        rb.velocity += (Vector3.up * jumpSpeed);
    
    }
}
        
