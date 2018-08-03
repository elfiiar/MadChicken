using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "verloren")
        {
            Destroy(gameObject);
            Variablen.WeltStop = 0;
        }

        if(other.gameObject.tag == "sammelobjekt")
        {
            Destroy(other.gameObject);
            Score.score += 1;
        }
    }
}
