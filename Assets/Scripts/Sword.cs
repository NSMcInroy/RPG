using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{

    public List<BaseStat> Stats { get; set; }
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Attack()
    {
        animator.SetTrigger("Base_Attack");
    }

    public void SpecialAttack()
    {
        animator.SetTrigger("Special_Attack");
    }

    void OnTriggerEnter(Collider _Col)
    {
            Debug.Log("Hit");

        if (_Col.tag == "Enemy")
        {
            _Col.gameObject.GetComponent<IEnemy>().TakeDamage(1f);
        }
    }
}
