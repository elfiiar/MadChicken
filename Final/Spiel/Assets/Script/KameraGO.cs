using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraGO : MonoBehaviour {

    //Kamera GameOver
    //https://docs.unity3d.com/ScriptReference/Camera-fieldOfView.html
    //public Transform targetPos;
    float timeMoved = 2f;
    float FieldOfView;
    public float moveSpeed = 10f;
    // Use this for initialization
    void Start () {
        FieldOfView = 53f;
    }
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        Camera.main.fieldOfView = FieldOfView;

        if ((Time.time - timeMoved) > 15f)
        {
            timeMoved = Time.time;
            transform.position = new Vector3(0.0f, 300f, 700f);
            //transform.LookAt(targetPos.position);
        }
        
    }
}
