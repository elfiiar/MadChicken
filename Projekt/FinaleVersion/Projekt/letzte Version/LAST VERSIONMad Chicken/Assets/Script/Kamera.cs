using UnityEngine;
using System.Collections;

public class Kamera : MonoBehaviour
{
    private float geschwindigkeit = 7.0f;
    private float geschwindigkeitErhöhen = 0.1f;
    private GameObject player;
    private bool setOnlyOneTime = true;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //Geschwindigkeit erhöhen
        int z = (int)player.transform.position.z;
        if (z % 100 == 0 && setOnlyOneTime)
        {
            geschwindigkeit += geschwindigkeitErhöhen;
            Debug.Log("geschwindigkeit erhöht");
        }
        else if (z % 100 != 0)
        {
            setOnlyOneTime = true;
        }


        transform.Translate(Vector3.forward * Time.deltaTime * geschwindigkeit);
    }
}