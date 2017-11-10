using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour, IEnemy {

    public float currentHealth, maxHealth, power, toughnss;

    public void PerformAttack()
    {
        throw new NotImplementedException();
    }

    public void TakeDamage(float _Amount)
    {
        currentHealth -= _Amount;
        if (currentHealth <= 0)
            Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start ()
    {
        currentHealth = maxHealth;
	}


}
