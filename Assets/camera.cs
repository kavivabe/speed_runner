using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    Rigidbody rb;

    public float speed;
       

    public new Transform Camera;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(1);
           

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(Camera.forward.x, 0, Camera.forward.z) * speed);
            Debug.Log("qwerty");
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(Camera.right.x, 0, Camera.right.z) * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(Camera.forward.x, 0, Camera.forward.z) * -speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(Camera.right.x, 0, Camera.right.z) * -speed);
        }

    }

}