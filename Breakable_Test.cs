using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable_Test : MonoBehaviour
{
    [SerializeField] private GameObject breakobject;
    void Start()
    {
        breakobject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            breakobject.SetActive(false);
        }

    }
    //breaks the object, like glass


}
