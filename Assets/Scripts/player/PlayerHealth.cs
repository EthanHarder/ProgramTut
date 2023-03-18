using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthSystem
{
    protected override void DeathCheck()
    {
        if (_health == 0)
        {
            GetComponent<CapsuleCollider>().enabled = false;
            Overmind._manager.TransitionOut(true);
            
        }
    }
}
