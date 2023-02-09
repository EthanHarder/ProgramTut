using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float moveSpeed;
    public bool grounded;
    public float jumpForce;
    private Rigidbody rb;

    private Vector3 dir;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {     
        Move();
        Jump();
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            checkJumpForce();
        }
    }
    void Move()
    {
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(Input.GetKeyDown(KeyCode.W));
        float zInput = Input.GetAxis("Vertical");
        dir = new Vector3(xInput, 0, zInput).normalized * moveSpeed * Time.deltaTime;
        rb.AddForce(dir, ForceMode.Impulse);
       // rb.velocity = dir;
      
        dir.y = rb.velocity.y;


        Vector3 facingDir = new Vector3(xInput, 0, zInput);
        if (facingDir.magnitude > 0)
        {
            transform.forward = facingDir.normalized;
        }
        
    }

    void checkJumpForce()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse );

    }
}
