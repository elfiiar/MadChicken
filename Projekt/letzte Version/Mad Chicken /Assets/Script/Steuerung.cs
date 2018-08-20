using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steuerung : MonoBehaviour {
    
    private const float spurBreite = 2.0f;
    private CharacterController controller;
    private int spur = 1;

    private float jumpForce = 6.0f;
    private float gravity = 12.0f;
    private float verticalVelocity;

    //geschwindigkeit
    private float geschwindigkeit = 7.0f;
    private float speedIncreaseLastTick;
    private float speedIncreseTime = 10.0f;
    private float speedIncreaseAmount = 0.1f;
   



	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}

    // Update is called once per frame
    void Update()
    {
       //Geschwindigkeit erhöhen
        if(Time.time - speedIncreaseLastTick > speedIncreseTime){
            speedIncreaseLastTick = Time.time;
            geschwindigkeit += speedIncreaseAmount;
            Debug.Log("geschwindigkeit erhöht");
        }

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
        if (controller.isGrounded){
            verticalVelocity = -0.1f;

            if (Input.GetKeyDown(KeyCode.W))
            {
                verticalVelocity = jumpForce;
            }
        }
        verticalVelocity -= (gravity * Time.deltaTime);

    
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
