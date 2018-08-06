using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Variablen : MonoBehaviour {

   

    //Zeit
    public static float time;

    //game over
    public static string status="";
    public static float WeltStop = 1;
    public float warteZeit = 0;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        


        time += Time.deltaTime;

        if(status == "FAIL"){
            warteZeit += Time.deltaTime;
        }

        if(warteZeit > 1){
            SceneManager.LoadScene("GameOver");
        }

	}
}
