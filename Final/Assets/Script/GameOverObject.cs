using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverObject : MonoBehaviour {

    Animator anim;
    public Transform targetPos;
    float timeMove = 2f;
    float moveSpeed = 2f;
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
        //Bis zur Position (x,y,z) ab da bewegt sich der Farmer nicht mehr.
        if (transform.position == new Vector3(-59.38f, 0f, 448f))
        {
        }
        //Bis dahin bewegt sich die Figur entlang der Z Achse.
        else
        {
            transform.Translate(0, 0, 5);
            if ((Time.time - moveSpeed) > 1f)
            {
                moveSpeed = Time.time;
            }
        }
    }
    private void FixedUpdate()
    {
        //Ab der 3Sek ist die Kamera bei (x,y,z) Position und bewegt sich nicht mehr.
        if ((Time.time - timeMove) > 3f)
        {
            timeMove = Time.time;
            transform.position = new Vector3(-59.38f, 0f, 448f);
            transform.LookAt(targetPos.position);
        }

    }
}
