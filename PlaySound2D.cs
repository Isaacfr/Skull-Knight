using UnityEngine;
using System.Collections;

public class PlaySound2D : MonoBehaviour
{

    //I did not create this code, but it is used in my program

    public AudioClip Chirp;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(Chirp, transform.position);
        }
    }
}