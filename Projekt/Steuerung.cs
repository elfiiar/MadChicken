using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steuerung : MonoBehaviour {

    private const float spurBreite = 2.0f;
    private CharacterController controller;
    private float geschwindigkeit = 7.0f;
    private int spur = 1;

    private float jumpForce = 2.0f;
    private float gravity = 12.0f;
    private float verticalVelocity;


	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}

    // Update is called once per frame
    void Update()
    {
        //Links
        if (Input.GetKeyDown(KeyCode.A))
        {
            spur += -1;
            spur = Mathf.Clamp(spur, 0, 2);

        }
        //Rechts
        if (Input.GetKeyDown(KeyCode.D))
        {
            spur += 1;
            spur = Mathf.Clamp(spur, 0, 2);

        }

        //Springen
        if(controller.isGrounded){
            verticalVelocity = -0.1f;
            if (Input.GetKeyDown(KeyCode.W))
            {
                verticalVelocity = jumpForce;
            }
            else
            {
                verticalVelocity -= (gravity * Time.deltaTime);
            }
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
        moveVector.y = verticalVelocity;
        moveVector.z = geschwindigkeit;

        //bewege das Huhn
        controller.Move(moveVector * Time.deltaTime);

        //leichtes Rotieren beim Spurwechsel
        Vector3 dir = controller.velocity;
        dir.y = 0;
        transform.forward = Vector3.Lerp(transform.forward, dir, 0.05f);
	}

}
