using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tueroeffner : MonoBehaviour {

    Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("Tuerzu", true);
        }
        
    }
}
