using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatisEnemy;
    public int damage;

    void Update()
    {
        //Delay for Attack
        if(timeBtwAttack <= 0)
        {
            //LeftCtrl will be attack button
            if (Input.GetKey(KeyCode.LeftControl))
            {
                GetComponent<Animator>().SetBool("IsAttacking", true);

                //Attack will deal damage to the collider of an enemy
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatisEnemy);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }  
            }
            else
            //if not attacking, animation is turned off
            {
                GetComponent<Animator>().SetBool("IsAttacking", false);
            }
            timeBtwAttack = startTimeBtwAttack;
            //delay begins
        }
        else
        {
            //when delayed, delay time decreases
            timeBtwAttack -= Time.deltaTime;
        }
    }
    //circle for range of attack
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
