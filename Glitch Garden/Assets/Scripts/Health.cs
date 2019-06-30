using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            if (GetComponent<Attacker>())
            {
                var attacker = GetComponent<Attacker>();
                attacker.DeathVFX();
            }
            else if (GetComponent<Defender>())
            {
                var defender = GetComponent<Defender>();
                defender.DeathVFX();
            }
            
            Destroy(gameObject);            
        }
    }

}
