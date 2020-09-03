using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brad_Transform : MonoBehaviour
{
    private bool activated = false;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!activated)
        {
            if (collision.CompareTag("Player"))
            {
                anim.SetTrigger("Transform_Trigger");
            }
        }
    }
}
