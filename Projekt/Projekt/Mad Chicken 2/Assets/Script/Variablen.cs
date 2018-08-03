using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Variablen : MonoBehaviour {
    public static float WeltStop = 1;

    //Score
    public static string status = "";
    public float warteZeit = 0;

    //Strecke
    public Transform strecke;

    //Zeit
    public static float time;


	// Use this for initialization
	void Start () {
        time += Time.deltaTime;


	}
	
	// Update is called once per frame
	void Update () {
	}
}
