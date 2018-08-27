using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegung2 : MonoBehaviour {

    /*
     * Idee von:
     * https://docs.unity3d.com/ScriptReference/Quaternion.Slerp.html
     * 
     */
    public Transform from;
    public Transform to;

    private float timeCount = 00.00f;
    // Use this for initialization
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount);
        timeCount = timeCount + Time.deltaTime;
    }
}
