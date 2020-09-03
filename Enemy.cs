using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public AudioClip Ding;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(Ding, transform.position);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Damage Taken!");
    }
}
