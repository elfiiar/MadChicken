using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }

        if(other.gameObject.tag == "sammelobjekt")
        {
            Destroy(other.gameObject);
        }
    }
}
