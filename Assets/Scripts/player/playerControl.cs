using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float moveSpeed;
    public bool grounded;
    public float jumpForce;

    private Vector3 dir;


    void Start()
    { 
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
        float zInput = Input.GetAxis("Vertical");
        dir = new Vector3(xInput, 0, zInput).normalized * moveSpeed * Time.deltaTime;
        if (dir.magnitude > 0)
        {
            PlayerSingleton.pInstance.pAnimator.SetBool("Walking", true);
        }
        else
        {
            PlayerSingleton.pInstance.pAnimator.SetBool("Walking", false);
        }
        PlayerSingleton.pInstance.pRigid.AddForce(dir, ForceMode.Impulse);
      
        dir.y = PlayerSingleton.pInstance.pRigid.velocity.y;


        Vector3 facingDir = new Vector3(xInput, 0, zInput);
        if (facingDir.magnitude > 0)
        {
            PlayerSingleton.pInstance.pTransform.forward = facingDir.normalized;
        }
        
    }

    void checkJumpForce()
    {
        PlayerSingleton.pInstance.pRigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse );

    }
}
