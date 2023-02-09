using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    [SerializeField]
    public List<string> validDamageSources;
    [SerializeField]
    public int Health;
    public void RecieveDamageAttempt(string source)
    {
       foreach (string s in validDamageSources)
        {
            if (s == source)
            {
                takeDamage();
            }
        }
    }

    protected virtual void takeDamage()
    {
        Health -= 1;
        DeathCheck();
    }

    protected virtual void takeDamage(int Amount)
    {
        Health -= Amount;
        DeathCheck();
    }

    protected virtual void DeathCheck()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }


}
