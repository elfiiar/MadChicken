using UnityEngine;

public class Steuerung : MonoBehaviour {

    private CharacterController controller;

    private const float spurBreite = 2.0f;
    private int spur = 1;

    //Springen
    private float springKraft = 6.0f;
    private float gravity = 12.0f;
    private float verticaleVeloctiy;

    //geschwindigkeit
    private float geschwindigkeit = 7.0f;
    private float geschwindigkeitErhöhen = 0.1f;
   

    private GameObject player;
    private bool setOnlyOneTime = true;


	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();

        player = GameObject.FindGameObjectWithTag("Player");
	}

    // Update is called once per frame
    void Update()
    {
        //Geschwindigkeit erhöhen
        int z = (int)player.transform.position.z;
        if (z % 50 == 0 && setOnlyOneTime)
        {
            geschwindigkeit += geschwindigkeitErhöhen;
           // Debug.Log("geschwindigkeit erhöht");
            setOnlyOneTime = false;
        }  
        else if (z % 50 != 0)
        {
            setOnlyOneTime = true;
        }


        //Links
        if (Input.GetKeyDown(KeyCode.A))
        {
            spur -= 1;
            spur = Mathf.Clamp(spur, 0, 2);

        }
        //Rechts
        if (Input.GetKeyDown(KeyCode.D))
        {
            spur += 1;
            spur = Mathf.Clamp(spur, 0, 2);

        }

        //rechnet aus wo die nächste Position ist
        Vector3 nächstePosition = Vector3.forward * transform.position.z;
        if (spur == 0)
        {
            nächstePosition += Vector3.left * spurBreite;
        }
        else if (spur == 2)
        {
            nächstePosition += Vector3.right * spurBreite;
        }


        //Springen
        if (controller.isGrounded){
            verticaleVeloctiy = -0.1f;

            if (Input.GetKeyDown(KeyCode.W))
            {
                verticaleVeloctiy = springKraft;
            }
        }
        verticaleVeloctiy -= (gravity * Time.deltaTime);

        Vector3 moveVector = Vector3.zero;
        //wo wir sein sollten - wo wir sind.normalized und nehmen x * geschwindigkeit
        moveVector.x = (nächstePosition - transform.position).normalized.x * geschwindigkeit;
        moveVector.y = verticaleVeloctiy;
        moveVector.z = geschwindigkeit;

        //bewege das Huhn
        controller.Move(moveVector * Time.deltaTime);
	}
}
