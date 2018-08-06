using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      //  GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -6);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -6 * Variablen.WeltStop);


	}
}
