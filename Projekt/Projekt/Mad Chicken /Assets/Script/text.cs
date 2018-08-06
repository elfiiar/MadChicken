using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.name == "Score")
        {
            GetComponent<TextMesh>().text = "Score: " + Score.score;
        } 
        if (gameObject.name == "Time"){
            GetComponent<TextMesh>().text = "Time: " + Variablen.time;
        }
	}
}
