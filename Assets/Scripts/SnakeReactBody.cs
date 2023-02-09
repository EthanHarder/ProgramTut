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
            if (playerRef != null)
            {
                Vector3 direction = (playerRef.transform.position - transform.position).normalized;
                Quaternion lookRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
            }
        }
    }
}
