using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeReactBody : EnemyReactBody
{
    // Start is called before the first frame update

    protected override void Update()
    {
        base.Update();
        if (alert)
        {
            if (PlayerSingleton.pInstance != null)
            {
                Vector3 direction = (PlayerSingleton.pInstance.pTransform.position - transform.position).normalized;
                Quaternion lookRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
            }
            Agent.SetDestination(PlayerSingleton.pInstance.pTransform.position);
        }
        else
            Agent.SetDestination(spawnLoc);
    }
}
