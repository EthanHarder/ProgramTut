using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class EnemyReactBody : MonoBehaviour
{

    protected Vector3 spawnLoc;
    protected GameObject playerRef;
    protected GameObject rangeRef;
    
    
    protected float speed;
    public float alertTime;
    public bool alert;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        spawnLoc = transform.position;
        playerRef = GameObject.Find("Ranger");
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (CheckAttentionLost())
        {
            AlertTimeDecrease();
        }




    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other == playerRef.GetComponent<Rigidbody>())
        {
            alert = true;
        }
    }

    protected virtual void OnCollisionEnter(Collision other)
    {
        Debug.Log("Cat");
        if (other.rigidbody != null && other.rigidbody.GetComponent<HealthSystem>() != null)
        {
            other.rigidbody.GetComponent<HealthSystem> ().RecieveDamageAttempt("Enemy");
        }
    }

    protected virtual bool CheckAttentionLost()
    {
        return alertTime <= 0.0f;
    }

    protected virtual void AlertTimeDecrease()
    {
        alertTime -= Time.deltaTime;
    }

}
