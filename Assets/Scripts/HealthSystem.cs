using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    [SerializeField]
    public List<string> validDamageSources;
    [SerializeField]
    public int _health;
    public virtual void RecieveDamageAttempt(string source)
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
        _health -= 1;
        DeathCheck();
    }

    protected virtual void takeDamage(int Amount)
    {
        _health -= Amount;
        DeathCheck();
    }

    protected virtual void DeathCheck()
    {
        if (_health <= 0)
        {
            Destroy(this.gameObject);
        }
    }


}
