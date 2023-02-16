using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class EnemyReactBody : MonoBehaviour
{

    protected Vector3 spawnLoc;
    protected GameObject rangeRef;
    
    
    protected float speed;
    public float alertTimer;
    public float alertAttentionTime;
    public bool alert;
    public bool alerted;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        spawnLoc = transform.position;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (!alerted)
        {
            AlertTimeDecrease();
        }
        if (CheckAttentionLost())
        {
            alert = false;
        }




    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other == PlayerSingleton.pInstance.GetComponent<CapsuleCollider>())
        {
            Debug.Log("Cat");
            alert = true;
            alerted = true;
            alertTimer = alertAttentionTime;
        }
    }

    protected virtual void OnTriggerExit(Collider other)
    {
        
        if (other == PlayerSingleton.pInstance.GetComponent<CapsuleCollider>())
        {
            Debug.Log("Dog");
            alerted = false;
        }
    }

    protected virtual void OnCollisionEnter(Collision other)
    {
        
        if (other.rigidbody != null && other.rigidbody.GetComponent<HealthSystem>() != null)
        {
            other.rigidbody.GetComponent<HealthSystem> ().RecieveDamageAttempt("Enemy");
        }
    }

    protected virtual bool CheckAttentionLost()
    {
        return alertTimer <= 0.0f;
    }

    protected virtual void AlertTimeDecrease()
    {
        if (alertTimer > 0.0f)
        alertTimer -= Time.deltaTime;
    }

}
