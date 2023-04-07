using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    [SerializeField]
    float value;

    [SerializeField]
    string pickUpModifyOperation;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MovementChange<float> speedUP = new MovementChange<float>();
            speedUP.change = value;
            speedUP.operation = pickUpModifyOperation;
            other.GetComponent<playerControl>().ModifyMoveSpeed(speedUP);
            Destroy(this.gameObject);
        }
    }
}
