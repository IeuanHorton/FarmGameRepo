using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * movementSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * movementSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * movementSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * movementSpeed;
        }
    }
}
