using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraGO : MonoBehaviour {

    //Kamera GameOver
    //https://docs.unity3d.com/ScriptReference/Camera-fieldOfView.html
    public Transform targetPos;
    float timeMoved = 1.5f;
    float FieldOfView;
    public float moveSpeed = 0.1f;

    // Use this for initialization
    void Start () {
        FieldOfView = 53f;
    }
	// Update is called once per frame
	void Update () {
        if (transform.position == new Vector3(0.0f, 300f, 700f)) {

        }
        else{
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime); 
        }
        Camera.main.fieldOfView = FieldOfView;
    }
    private void FixedUpdate()
    {
        if ((Time.time - timeMoved) > 3f)
        {
            timeMoved = Time.time;
            transform.position = new Vector3(0.0f, 300f, 700f);
            transform.LookAt(targetPos.position);
        }
    }
}
