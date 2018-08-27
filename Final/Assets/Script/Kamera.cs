using UnityEngine;
using System.Collections;

public class Kamera : MonoBehaviour
{
    private GameObject player;

    private float geschwindigkeit = 7.0f;
    private float geschwindigkeitErhöhen = 0.1f;
    private bool setOnlyOneTime = true;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * geschwindigkeit);

        //Geschwindigkeit erhöhen
        int z = (int)player.transform.position.z;
        if (z % 50 == 0 && setOnlyOneTime)
        {
            geschwindigkeit += geschwindigkeitErhöhen;
            Debug.Log("geschwindigkeit erhöht");
            setOnlyOneTime = false;

        }
        else if (z % 50 != 0)
        {
            setOnlyOneTime = true;
        }
   
    }
}