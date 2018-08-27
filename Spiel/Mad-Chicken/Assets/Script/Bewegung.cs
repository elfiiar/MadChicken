using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegung : MonoBehaviour {

    /*
     * Idee von:
     * https://docs.unity3d.com/ScriptReference/Quaternion.Slerp.html
     * 
     */
    public Transform from;
    public Transform to;
    private float timeCount = 11f;

    private void Start()
    {

    }

    void Update()
    {
        transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount);
        timeCount = timeCount * timeCount * timeCount * Time.deltaTime;
    }
}
