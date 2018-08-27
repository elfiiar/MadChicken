using UnityEngine;

public class Steuerung : MonoBehaviour {

    //Code wurde mit Hilfe von Tutorial gemacht: https://www.youtube.com/watch?v=C9qoYdslLcg
    //Player ist aus dem Internet: https://www.blendswap.com/blends/view/76321,  Lizenz ist auf Github 
    private CharacterController controller;

    //Breite der Spur
    private const float spurWidth = 2.0f;
    //Aktuelle Spur
    private int spur = 1;

    //Springen
    private float jumpForce = 6.0f;
    private float gravity = 12.0f;
    private float verticaleVeloctiy;

    //Anfangsgeschwindigkeit
    private float geschwindigkeit = 7.0f;
    //wird addiert wenn Geschwindigkeit erhöht werden soll
    private float geschwindigkeitErhöhen = 0.1f;
   
    //Auto-Init
    private GameObject player;
    //sorgt dafür das es nur einmal pro Framezahl gilt
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
            //sorgt dafür das es nur drei spuren gibt
            spur = Mathf.Clamp(spur, 0, 2);

        }
        //Rechts
        if (Input.GetKeyDown(KeyCode.D))
        {
            spur += 1;
            //sorgt dafür das es nur drei spuren gibt
            spur = Mathf.Clamp(spur, 0, 2);

        }

        //rechnet aus wo die nächste Position ist
        Vector3 nächstePosition = Vector3.forward * transform.position.z;
        //wenn A gedrückt wurde und spur = 0 ist, dann ist die nächste Position nach links * spurWidth(2)
        if (spur == 0)
        {
            nächstePosition += Vector3.left * spurWidth;
        }
        //wenn spur == 1
        else if (spur == 1)
        {
            nächstePosition += Vector3.zero * spurBreite;
        }
        //wenn D gedrückt wurde und spur = 2 ist, dann ist die nächste Position nach rechts * spurWidth(2)
        else if (spur == 2)
        {
            nächstePosition += Vector3.right * spurWidth;
        }


        //Springen
        if (controller.isGrounded){
            verticaleVeloctiy = -0.1f;

            if (Input.GetKeyDown(KeyCode.W))
            {
                verticaleVeloctiy = jumpForce;
            }
        }
        verticaleVeloctiy -= (gravity * Time.deltaTime);


        Vector3 moveVector = Vector3.zero;        //Vector.zero = (0, 0, 0)
        //wo wir sein wollen MINUS wo wir sind --> normalized und nehmen x * geschwindigkeit
        moveVector.x = (nächstePosition - transform.position).normalized.x * geschwindigkeit;  //links, mitte oder rechts
        moveVector.y = verticaleVeloctiy;   //Springen
        moveVector.z = geschwindigkeit;     

        //bewege das Huhn
        controller.Move(moveVector * Time.deltaTime);
	}
}
