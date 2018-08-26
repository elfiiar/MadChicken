using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverObject : MonoBehaviour {

    Animator anim;
    float timeMoved = 2f;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("Walk");
    }
    void Update()
    {
        transform.Translate(0, 0, 5);
        if ((Time.time - timeMoved) > 1.5f)
        {
            timeMoved = Time.time;
        }
    }
}
