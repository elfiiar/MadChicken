using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steuerung : MonoBehaviour {

    private const float spurBreite = 2.0f;
    private CharacterController controller;
    private float geschwindigkeit = 7.0f;
    private int spur = 1;


	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //Links
        if(Input.GetKeyDown(KeyCode.A))
        {
            WechseleSpur(false);
        }
        //Rechts
        if (Input.GetKeyDown(KeyCode.D))
        {
            WechseleSpur(true);
        }

        //Ausrechnen
        Vector3 nächstePosition =Vector3.forward * transform.position.z;
        if(spur == 0 ){
            nächstePosition += Vector3.left * spurBreite;
        } else if (spur ==2){
            nächstePosition += Vector3.right * spurBreite;

        }

        Vector3 moveVector = Vector3.zero;
        moveVector.x = (nächstePosition - transform.position).normalized.x * geschwindigkeit;
        moveVector.y = -0.1f;
        moveVector.z = geschwindigkeit;

        //bewege das Huhn
        controller.Move(moveVector * Time.deltaTime);
	}

    private void WechseleSpur (bool goingRight){
        //left
        //wenn goingRight = true, dann 1; wenn false -1
        spur += (goingRight) ? 1 : -1;
        spur = Mathf.Clamp(spur, 0, 2);
    }
}
