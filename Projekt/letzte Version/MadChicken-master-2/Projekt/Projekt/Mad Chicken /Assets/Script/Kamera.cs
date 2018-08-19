using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour {
    public Transform focus;
    public Vector3 abstand = new Vector3(0, 4.5f, -3.0f);
	// Use this for initialization
	void Start () {
        transform.position = focus.position + abstand;
	}
	
	// Update is called once per frame
	void Update () {
        if (!focus.Equals(null)) {
            Vector3 camPosition = focus.position + abstand;
            camPosition.x = 0;
            camPosition.y = 4.5f;
            transform.position = Vector3.Lerp(transform.position, camPosition, Time.deltaTime);
        }
	}
}
