using UnityEngine;
using System.Collections;

public class Kamera : MonoBehaviour
{
    //Auto-Init
    private GameObject player;

    //Anfangsgeschwindigkeit
    private float geschwindigkeit = 7.0f;
    //wird addiert wenn Geschwindigkeit erhöht werden soll
    private float geschwindigkeitErhöhen = 0.1f;
    //sorgt dafür das es nur einmal pro Framezahl gilt
    private bool setOnlyOneTime = true;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //Bewegt Kamera der z-Achse entlang
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