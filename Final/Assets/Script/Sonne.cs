using System.Collections;
using UnityEngine;

public class Sonne : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
       transform.RotateAround(Vector3.one,Vector3.forward,4f*Time.deltaTime);
        //Dreht sich um den 0 Punkt nach rechts mit 10f Geschwindigkeit
        transform.LookAt(Vector3.one);
	}
}
