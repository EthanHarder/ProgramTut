using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingleton : MonoBehaviour
{

    public static PlayerSingleton pInstance { get; protected set; }
    public HealthSystem pHealth { get; private set; }
    public Transform pTransform { get; protected set; }
    public playerControl pControl { get; protected set; }
    public Animator pAnimator { get; protected set; }
    public Rigidbody pRigid { get; protected set; }

    private void Awake()
    {
        if (pInstance != null && pInstance != this)
        {
            Destroy(this.gameObject);
            return; //I dont think this matters if its destroyed, but it cant hurt
        }
        pInstance = this;
        pHealth = GetComponent<HealthSystem>();
        pTransform = GetComponent<Transform>();
        pControl = GetComponent<playerControl>();
        pAnimator = GetComponent<Animator>();
        pRigid = GetComponent<Rigidbody>();

    }

}
