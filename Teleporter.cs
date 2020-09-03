using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    //I did not create this code, but it is used in my program

    public GameObject sp1, sp2;
    
    void Start() {
        sp1 = this.gameObject;
    }

    void OnTriggerStay2D (Collider2D trig) {
        if (Input.GetKey(KeyCode.DownArrow)) {
            trig.gameObject.transform.position = sp2.gameObject.transform.position;
            
        }
        
    }

   
}
